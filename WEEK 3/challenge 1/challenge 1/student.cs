using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    internal class student
    {
        public student(string name1, float matricMarks, float fscMarks,float EcatMarks)
            {
            this.name = name1;
            this.matricMarks = matricMarks;
                this.fscMarks = fscMarks;
            this.EcatMarks = EcatMarks;
            }
        public string name;
        public float matricMarks;
        public float fscMarks;
        public float EcatMarks;
        public void Student_Data() 
        { 

        }    
    }
}
