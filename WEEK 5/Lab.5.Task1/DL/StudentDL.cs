using Lab._5.Task1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1.DL
{
    internal class StudentDL
    {
        public static List<StudentBL> Students = new List<StudentBL>();
        public static void AddStudent(StudentBL student)
        {
            Students.Add(student);
        }


    }
}
