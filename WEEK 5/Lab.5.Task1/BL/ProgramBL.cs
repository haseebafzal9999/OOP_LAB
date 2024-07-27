using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1.BL
{
    internal class ProgramBL
    {
       public string title;
       public string duration;
        public ProgramBL(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
        }
        public ProgramBL(string title)
        {
            this.title = title;
        }


    }
}
