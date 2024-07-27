using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Week5.BL
{
    internal class DegreeProgram
    {
        public DegreeProgram(string title,string duration) 
        {
            this.title = title;
            durationOfDegree = duration;

        }
        public DegreeProgram(string title)
        {
            this.title = title;

        }
        public DegreeProgram(string title, string duration,List<Subject> subjectList, int seats)
        {
            
            this.title = title;
            durationOfDegree = duration;
            this.subjectsList = subjectList;
            this.seats = seats;
        }
        public int degreeId;
        public string title;
        public string durationOfDegree;
        public int seats;
        List<Subject> subjectsList=new List<Subject>();

        public bool isSubjectExist(Subject sub)
        {
            foreach(Subject subject in subjectsList)
            {
                if(subject.subjectCode == sub.subjectCode)
                {
                    return true;
                }
            }
            return false;
        }
        public void addSubject(Subject subject) 
        {
            subjectsList.Add(subject);
        }
        public int TotalCreditHours()
        {
            int totalCH = 0;
            foreach(Subject subject in subjectsList)
            {
                totalCH += subject.creditHours;
            }
            return totalCH;
        }
        public List<Subject> GetSubjectList()
        {
            return subjectsList;
        }

    }
}
