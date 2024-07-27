using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_3
{
    internal class calcluator
    {
        public float num1;
        public float num2;
        public string option;
        public float Calcluator()
        {
              if(option == "+")
            {
                return num1 + num2;
            }
              else if(option == "-")
            {
                return num1 - num2;
            }
            else if (option == "*")
            {
                return num1 * num2;
            }
            else if (option == "/")
            {
                return num1 / num2;
          
            }
            else
            {
                Console.WriteLine("Enter valid input: ");
                return 0;
            }
              

        }

    }
}
