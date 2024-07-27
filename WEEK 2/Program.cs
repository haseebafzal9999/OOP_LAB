using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* S1.sname = "ABC";
             student[] studentsData = new student[5];*/
            /*         for(int i = 0; i<5; i++)
                     {
                         studentsData[i] = takeStudentInput();
                     }
                     printStudentsData(studentsData);
                     Console.ReadKey();*/

            /* %%%%%%%%%%%%%%%%%%%2%%%%%%%%%%%%%%%%%%%%*/
            /*     Console.WriteLine(s1.sname);
                 Console.WriteLine(s1.matricMarks);
                 Console.WriteLine(s1.fscMarks);
                 Console.WriteLine(s1.ecatMarks);
                 Console.WriteLine(s1.aggregate);
                 Console.ReadKey();*/

            /* #######SELF ASSESSMENT TASK1(B):
                 student s1 = new student("tayyab" , 600 ,900 , 300 );
                 student s2 = new student("kaleem" , 500 ,900 , 300 );
                 Console.WriteLine(s1.sname +"  "+ s1.matricMarks);
                 Console.WriteLine(s2.sname +"  "+ s2.matricMarks);
                 Console.ReadKey();*/



        }
        /*        static student takeStudentInput()
                {
                    student s = new student();
                    Console.WriteLine("Enter Student Name");
                    s.sname = Console.ReadLine();
                    Console.WriteLine("Enter Student Matric Marks");
                    s.matricMarks =float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Fsc Marks");
                    s.fscMarks = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Ecat Marks");
                    s.ecatMarks = float.Parse(Console.ReadLine());
                    return s;
                }
                static void printStudentsData(student[] studentsData)
                {
                    Console.WriteLine("Name \t MatricMarks \t FscMarks \t EcatMarks");
                    for (int i = 0; i < 5 ; i++)
                    {
                        Console.WriteLine(studentsData[i].sname +"\t" + studentsData[i].matricMarks + "\t" + studentsData[i].fscMarks + "\t" + studentsData[i].ecatMarks + "\t");
                    }
                }*/
    }
}
