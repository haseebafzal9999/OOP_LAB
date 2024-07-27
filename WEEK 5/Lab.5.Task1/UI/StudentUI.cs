using Lab._5.Task1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1.UI
{
    class StudentUI
    {
        public StudentBL GetStudentdata()
        {

			List<ProgramBL> list = new List<ProgramBL>();
            Console.WriteLine("Enter the Student Name:");
            string Name=Console.ReadLine();
			Console.WriteLine("Enter the Student Name:");
			int Age = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Student Name:");
			float FscMarks =float.Parse( Console.ReadLine());
			Console.WriteLine("Enter the Student Name:");
			float EcatMarks = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter  number of preference:");
             int No = int.Parse(Console.ReadLine());
			for(int i = 0; i < No; i++)
			{
				Console.WriteLine("Enter the Name of Subject:");
				string Degree = Console.ReadLine();
				ProgramBL newDegree = new ProgramBL(Degree);
				list.Add(newDegree);
			}
			StudentBL Stu = new StudentBL(Name, Age, FscMarks, EcatMarks);
			return Stu;
		}


	}
}
