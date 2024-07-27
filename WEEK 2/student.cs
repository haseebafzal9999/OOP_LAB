using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class student
    {
      /*  public student()
        {
          *//*  sname = "Tayyab";
            matricMarks = 10;
            fscMarks = 20;
            ecatMarks = 30;
            aggregate = 30;*/
/*            Console.WriteLine("Default Constructor Called");
*//*        }*/

        public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;

    public student(string name, int matric , int fsc, int ecat)
        {
        sname = name;
        matricMarks = matric;
        fscMarks = fsc;
        ecatMarks = ecat;
    }
    }
}
