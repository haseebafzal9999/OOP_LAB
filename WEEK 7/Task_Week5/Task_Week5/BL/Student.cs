using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Week5.BL
{
    internal class Student
    {
        public Student(string name,int age,float fscMarks,float ecatMarks,List<DegreeProgram> degreeList)
        {
            studentName=name;
            this.age=age;
            this.fscMarks=fscMarks;
            this.ecatMarks=ecatMarks;
            Preferences = degreeList;
        }
        public string studentName;
        public int age;
        public float fscMarks; 
        public float ecatMarks;
        public float merit;
        public float TotalFees;

        public List<DegreeProgram> Preferences = new List<DegreeProgram>();
        public List<Subject> registeredSubjects = new List<Subject>();
        public DegreeProgram registeredDegree;

        public void calculateMerit()
        {
            merit = (fscMarks * 0.60f) + (ecatMarks * 0.4f);
        }
        public void registerDegreeProgram(DegreeProgram degreeProgram)
        {
            registeredDegree = degreeProgram;
        }
        public List<DegreeProgram> getPreferences()
        {
            return Preferences;
        }
        public bool isRegistered()
        {
            if(registeredDegree != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkProgram(string program)
        {
            if(registeredDegree == null)
            {
                return false;
            }
            if(program==registeredDegree.title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RegStudentSubject(string subCode)
        {
            Subject subject = canStudentRegister(subCode);
            if (subject != null)
            {
                int totalCH = getCreditHours();
                int subjectCH = subject.GetCreditHours();
                if ((totalCH + subjectCH) > 9)
                {
                    return false;
                }
                else
                {
                    registeredSubjects.Add(subject);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int totalCH = 0;
            foreach(Subject subject in registeredSubjects)
            {
                totalCH += subject.GetCreditHours();
            }
            return totalCH;
        }
        public Subject canStudentRegister(string SubCode)
        {
            List<Subject> subjects = registeredDegree.GetSubjectList();
            foreach(Subject subject in subjects)
            {
                if(SubCode == subject.subjectCode)
                {
                    return subject;
                }
            }
            return null;
        }
        public void CalculateFees()
        {
            float totalFees = 0;
            foreach(Subject subject in registeredSubjects)
            {
                totalFees += subject.GetFee();
            }
            TotalFees = totalFees;
        }
    }
}
