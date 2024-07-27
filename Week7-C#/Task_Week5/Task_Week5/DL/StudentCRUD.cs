using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Week5.BL;
using System.Data;
using System.Data.SqlClient;

namespace Task_Week5.DL
{
    internal class StudentCRUD
    {
        public static List<Student> students = new List<Student>();
        public static List<Student> studentsMeritList = new List<Student>();
        public static string ConnectionString = "server=DESKTOP-ONT3FCQ\\SQLEXPRESS;database=UMSDatabase;Trusted_Connection=True;";
        public static void addStudent(Student student)
        {
            students.Add(student);
        }
        public static void addStudentIntoDb(Student student)
        {
            string query = string.Format("INSERT into Student (age,Name,EcatMarks,FScMarks,MatricMarks,Merit)"+
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",student.age,student.studentName,student.ecatMarks,student.fscMarks,student.matricMarks,student.merit);
            SqlConnection sqlConnection= new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand command=new SqlCommand(query,sqlConnection);
            int rowsAffected=command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static void meritList()
        {
            foreach(Student student1 in students)
            {
                student1.calculateMerit();
            }
            studentsMeritList = students.OrderByDescending(student => student.merit).ToList();
        }
        public static bool isStudentRegistered(string name)
        {
            foreach(Student student in studentsMeritList)
            {
                if(name==student.studentName) 
                    return true;
                break;
            }
            return false;
        }
        public static Student getStudent(string name)
        {
            foreach(Student student in students)
            {
                if (name == student.studentName)
                {
                    return student;
                    
                }
            }
            return null;
        }
        public static Student GetStudentFromDb(string dbName)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string query = string.Format("Select * from Student where Name={0}",dbName);
            SqlCommand command = new SqlCommand(query,sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Student student = new Student(reader["Id"], reader["age"], reader["Name"], reader["EcatMarks"], reader["FscMarks"], reader["MatricMarks"], reader["Merit"]),int.Parse( reader["DegreeId"]),float.Parse( reader["TotalFees"]));
            }
            else
            {

            }
        }
    }
}
