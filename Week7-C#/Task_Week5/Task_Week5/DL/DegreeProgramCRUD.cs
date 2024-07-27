using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Week5.BL;

namespace Task_Week5.DL
{
    internal class DegreeProgramCRUD
    {
        public static List<DegreeProgram> DegreeProgramsList= new List<DegreeProgram>();
        public static List<Student> registerStudentsList = new List<Student>();

        public static void addProgram(DegreeProgram degreeProgram)
        {
            DegreeProgramsList.Add(degreeProgram);
        }
        public static int GetDegreeCH()
        {
            int CH = 0;
            foreach(DegreeProgram degreeProgram in DegreeProgramsList)
            {
                CH += degreeProgram.TotalCreditHours();
            }
            return CH;
        }

        public static void registerStudents(Student student)
        {
           
                List<DegreeProgram> preferenceList=student.getPreferences();
                foreach(DegreeProgram preference in preferenceList)
                {
                    foreach(DegreeProgram availableProgram in DegreeProgramsList)
                    {
                        if (preference.title == availableProgram.title && availableProgram.seats>=1)
                        {
                            student.registerDegreeProgram(availableProgram);
                        registerStudentsList.Add(student);
                            availableProgram.seats -= 1;
                            return;
                        }

                    }
                }
            

        }
    }
}
