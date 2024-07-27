using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1.BL
{
    internal class SubjectBL
    {
        public string SubjectCode;
        public string SubjectType;
        public int SubjectFee;
        public int creditHour;
        public SubjectBL(string subjectCode, string subjectType, int subjectFee, int creditHour)
        {
            SubjectCode = subjectCode;
            SubjectType = subjectType;
            SubjectFee = subjectFee;
            this.creditHour = creditHour;
        }
    }
}
