using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Week5.BL;

namespace Task_Week5.DL
{
    internal class StudentCRUD
    {
        public static List<Student> students = new List<Student>();
        public static List<Student> studentsMeritList = new List<Student>();

        public static void addStudent(Student student)
        {
            students.Add(student);
        }
       

          public static string connectionString = "Server=DESKTOP-FDC3QN9\\SQLEXPRESS; Database=UMAS; Trusted_Connection=True;";
         public static Student CreateStudent(Student student)
         {
                string query = string.Format("INSERT INTO Students (Roll, Name, FatherName, Contact, Ecat, Matric, Fsc) " +
                                            "VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}', '{6}')",
                                            student.studentName, student.age,
                                            student.fscMarks, student.ecatMarks);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return student;
                }

                return null;
         }

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            string query = "SELECT * FROM Students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student(
                        Convert.ToString(reader["Roll"]),
                        Convert.ToString(reader["Name"]),
                        Convert.ToString(reader["FatherName"]),
                        Convert.ToString(reader["Contact"]),
                        Convert.ToSingle(reader["Ecat"]),
                        Convert.ToSingle(reader["Matric"]),
                        Convert.ToSingle(reader["Fsc"])
                    );
                    students.Add(student);
                }
            }

            return students;
        }

        public static void meritList()
        {
            foreach (Student student1 in students)
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
    }
}
