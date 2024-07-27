using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shery s1 = new shery();
            shery s2 = new shery(); 

            Console.WriteLine("Enter te name: ");
            s1.name = Console.ReadLine();
        }
        static string Abc(shery s1)
        {
            return s1.name= "Abc";

        }
    }
}
