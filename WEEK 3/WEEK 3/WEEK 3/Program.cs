using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float s2;
            calcluator s1 = new calcluator();   
            Console.WriteLine("Enter the num1 :");
            s1.num1 = float.Parse( Console.ReadLine());
            Console.WriteLine("Enter the num2 :");
            s1.num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator(+ , - , * , /): ");
            s1.option = Console.ReadLine();
            s2 = s1.Calcluator();
            Console.WriteLine(s2);
            Console.ReadLine();
               
        }
    }
}
