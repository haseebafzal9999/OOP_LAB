using System;
using System.Collections.Generic;
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
    }
}
