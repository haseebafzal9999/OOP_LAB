using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Week5.BL;

namespace Task_Week5.UI
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram InputDegreeData()
        {
            List<Subject> subjects = new List<Subject>();
            Console.Write("Enter Degree Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            string duration=Console.ReadLine();
            Console.Write("Enter Degree Seats: ");
            int seats=int.Parse(Console.ReadLine());
            Console.Write("Enter How many subjects to enter: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Subject newSubject= new Subject();
                Console.Write("Enter Subject Code: ");
                newSubject.subjectCode=(Console.ReadLine()) ;
                Console.Write("Enter Subject Type: ");
                newSubject.subjectType=(Console.ReadLine()) ;
                Console.Write("Enter Subject Credit Hours: ");
                newSubject.creditHours=int.Parse(Console.ReadLine()) ;
                Console.Write("Enter Subject Fees: ");
                newSubject.subjectFee=int.Parse(Console.ReadLine()) ;

                subjects.Add(newSubject);
            }
            DegreeProgram newDegree=new DegreeProgram(name,duration,subjects,seats);
            return newDegree;
        }
    }
}
