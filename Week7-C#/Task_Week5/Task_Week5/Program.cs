using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_Week5.BL;
using Task_Week5.DL;
using Task_Week5.UI;

namespace Task_Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            int option = mainMenu();
            if(option == 1)
            {
                Student newStudent = StudentUI.GetStudentdata();
                StudentCRUD.addStudent(newStudent);
                StudentCRUD.meritList();
                StudentCRUD.addStudentIntoDb(newStudent);
            }
            else if(option == 2)
            {
                DegreeProgram newDegree = DegreeProgramUI.InputDegreeData();
                DegreeProgramCRUD.addProgram(newDegree);

            }
            else if(option == 3)
            {
                foreach (Student student in StudentCRUD.studentsMeritList)
                {
                    if (!student.isRegistered())
                    {
                        DegreeProgramCRUD.registerStudents(student);
                    }
                }
                StudentUI.ShowGenerateMerit();
            }
            else if(option == 4)
            {

                foreach (Student student in StudentCRUD.studentsMeritList)
                {
                    if (!student.isRegistered())
                    {
                        DegreeProgramCRUD.registerStudents(student);
                    }
                }
                StudentUI.showRegisterStudents();

            }
            else if(option == 5)
            {
                //search by specific degree
                StudentUI.ShowByDegree();
            }
            else if(option==6)
            {
                //register subject
                string name = StudentUI.getStudentName();
                if (StudentCRUD.isStudentRegistered(name))
                {
                    string subCode = StudentUI.getSubjectData();
                    Student student = StudentCRUD.getStudent(name);
                   if (student != null)
                    {
                        if (!student.RegStudentSubject(subCode))
                        {
                            StudentUI.ShowInvalidIput();
                        }
                    }
                    else
                    {
                        StudentUI.ShowInvalidIput();
                    }
                }
                else
                {
                    StudentUI.ShowInvalidIput();
                }
                
            }
            else if(option == 7)
            {
                //fee for all registered students
                foreach(Student student in DegreeProgramCRUD.registerStudentsList)
                {
                    student.CalculateFees();

                }
                StudentUI.GenerateFee();
            }
            else if(option == 8)
            {
                return;
            }
            else
            {
                
                
                Console.WriteLine("Enter correct option.");
            }
            Console.ReadKey();
            goto Start;
            
        }
        static int mainMenu()
        {
            Console.Clear();
            Console.WriteLine("***************************************************");
            Console.WriteLine("                        UAMS                       ");
            Console.WriteLine("***************************************************");
            Console.WriteLine("1.  Add Student.");
            Console.WriteLine("2.  Add Degree Program.");
            Console.WriteLine("3.  Generate Merit.");
            Console.WriteLine("4.  View Registered Students.");
            Console.WriteLine("5.  View Students of a Specific Program.");
            Console.WriteLine("6.  Register Subjects for a specific Student.");
            Console.WriteLine("7.  Calculate Fees for all Registered Students.");
            Console.WriteLine("8.  Exit.");
            Console.Write("Enter Option: ");
            int value=int.Parse(Console.ReadLine());
            return value;
        }
    }
}
