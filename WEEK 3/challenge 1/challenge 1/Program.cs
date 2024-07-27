using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> list = new List<student>();
            list.Add(new student("Tayyab",100,200,300));
            list.Add(new student("Ali",100,200,300));
            list.Add(new student("Ahmad",100,200,300));
            list.Add(new student("Bilal",100,200,300));

        }


    }
}
