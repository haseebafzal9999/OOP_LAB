using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labwork.BL;
using Labwork.DL;


namespace ConsoleApp1.UI
{
    internal class StudentUI
    {
        public static Student GetStudentdata()
        {
            // List<DegreeProgram> list = new List<DegreeProgram>();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Roll: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Matric Marks: ");
            float matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            /*            Console.Write("Enter how many Number of Preferences: ");
                        int no = int.Parse(Console.ReadLine());
                        for (int i = 0; i < no; i++)
                        {
                            Console.Write("Enter degree Name: ");
                            string degreeName = Console.ReadLine();
                            DegreeProgram newDegree = new DegreeProgram(degreeName);
                            list.Add(newDegree);
                        }*/
            Student newStudent = new Student(roll, name, ecatMarks, matricMarks, fscMarks);
            return newStudent;
        }
    }
}
