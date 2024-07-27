using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Week5.BL;
using Task_Week5.DL;

namespace Task_Week5.UI
{
    internal class StudentUI
    {
        public static Student GetStudentdata()
        {
            List<DegreeProgram> list = new List<DegreeProgram>();
            Console.Write("Enter Student Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            float fscMarks=float.Parse(Console.ReadLine());
            Console.Write("Enter Student ecat Marks: ");
            float ecatMarks=float.Parse(Console.ReadLine());
            Console.Write("Enter how many Number of Preferences: ");
            int no = int .Parse(Console.ReadLine());
            for(int i = 0; i < no; i++)
            {
                Console.Write("Enter degree Name: ");
                string degreeName=Console.ReadLine();
                DegreeProgram newDegree = new DegreeProgram(degreeName);
                list.Add(newDegree);
            }
            Student newStudent = new Student(name, age, fscMarks, ecatMarks, list);
            return newStudent;
        }
        public static void showRegisterStudents()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach(Student student in StudentCRUD.studentsMeritList)
            {
                if (student.registeredDegree!=null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.studentName, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }
        public static void ShowGenerateMerit()
        {
            foreach(Student student in StudentCRUD.studentsMeritList)
            {
                if(student.isRegistered())
                {
                    Console.WriteLine("{0} got Admission in {1}",student.studentName,student.registeredDegree.title);
                }
                else
                {
                    Console.WriteLine("{0} did not get Admission", student.studentName);
                }
            }
        }
        public static void ShowByDegree()
        {
            Console.Write("Enter Degree Name: ");
            string degreeName=Console.ReadLine();
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student student in StudentCRUD.studentsMeritList)
            {
                if (student.checkProgram(degreeName))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.studentName, student.fscMarks, student.ecatMarks, student.age);
                }
            }
        }
        public static string getStudentName()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string getSubjectData()
        {
            Console.Write("Enter Subject Code: ");
            string subCode = Console.ReadLine();
            return subCode;
        }
        public static void ShowInvalidIput()
        {
            Console.WriteLine("Sorry, You cannot register subject.");
        }
        public static void GenerateFee()
        {
            Console.WriteLine("Name\tTotalFees");
            foreach(Student student in DegreeProgramCRUD.registerStudentsList)
            {
                Console.Write("{0}\t{1}", student.studentName, student.TotalFees);
            }
        }

    }
}
