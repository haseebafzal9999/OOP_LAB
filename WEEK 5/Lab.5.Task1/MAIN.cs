﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5.Task1
{
    internal class MAIN
    {
        static void Main(string[] args)
        {
            int option = 0;
            int value = 1;
            while(option != -1)
            {
                value = mainMenu();
                if(value == 1)
                {

                }
            }

        }
        static int mainMenu()
        {
            Console.Clear();
            Console.WriteLine("***************************************************");
            Console.WriteLine("                        UAMS                       ");
            Console.WriteLine("***************************************************");
            Console.WriteLine("1.  Add Student.");
            Console.WriteLine("2.  Add Degree Program.");
            Console.WriteLine("3.  Generate Merit.");
            Console.WriteLine("4.  View Registered Students.");
            Console.WriteLine("5.  View Students of a Specific Program.");
            Console.WriteLine("6.  Registered Subjects for a Specific Student.");
            Console.WriteLine("7.  Calculate Fees for all Registered Students.");
            Console.WriteLine("8.  Exit.");
            Console.Write("Enter Option: ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }
    }
}
