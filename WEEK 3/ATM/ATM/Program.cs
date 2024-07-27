using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            atm s1 = new atm();
            int option = 1;
            while(option != 0){ 
            value = Menu();
            if(value == 1)
            {
                s1.initialization();
            }
            else if(value == 2)
            {
                s1.Deposit();
            }
            else if (value == 3)
            {
                s1.WithDraw();
            }
           
            else if (value == 4)
            {
                s1.balance();
            }
            else if (value == 5)
            {
                s1.transac();
            }
            else
            {
                Console.WriteLine("Enter valid input: ");
            }
            Console.ReadKey();
            }
        }
        static int Menu()
        {
            int option;
           
            Console.WriteLine();
            Console.WriteLine("1 initialization:  ");
            Console.WriteLine("2 Deposit:  ");
            Console.WriteLine("3 Withdrawal:  ");
            Console.WriteLine("4 Check Balance:  ");
            Console.WriteLine("5 Transaction History:  ");
            Console.WriteLine("Enter the option:  ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
