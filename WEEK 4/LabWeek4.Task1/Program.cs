using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek4.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer Cus =new customer();
            Console.WriteLine("Enter the Customer Name:");
            Cus.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the Customer Adress:");
            Cus.CustomerAdress = Console.ReadLine();
            Console.WriteLine("Enter the Customer Contact:");
            Cus.CustomerContact = Console.ReadLine();


        }
    }
}
