using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1.BL
{
    class StudentBL
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EcatMarks;
        public float Merit;
        public List<ProgramBL> Preference = new List<ProgramBL>();
        public StudentBL(string Name, int Age, float FscMarks, float EcatMarks)
        {
            this.Name = Name;
            this.Age = Age;
            this.FscMarks = FscMarks;
            this.EcatMarks = EcatMarks;
        }
        public void CalcluateMerit()
        {
          Merit=  (FscMarks * EcatMarks) / 100;
		}
      
      
    }
}
