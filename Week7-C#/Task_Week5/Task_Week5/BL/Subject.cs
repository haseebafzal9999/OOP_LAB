using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Week5.BL
{
    internal class Subject
    {
        public Subject() { }
        public int SubjectId;
        public string subjectCode;
        public string subjectType;
        public int creditHours;
        public int subjectFee;

        public int GetCreditHours()
        {
            return creditHours;
        }
        public float GetFee()
        {
            return subjectFee;
        }

    }

}
