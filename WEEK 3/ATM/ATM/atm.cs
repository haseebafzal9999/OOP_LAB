using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class atm
    {
        public int AtmBalance;
        public List<int> transaction = new List<int>();
        public int amount;
        public void initialization()
        {
            Console.WriteLine("Enter the Balance :");
             AtmBalance =int.Parse( Console.ReadLine());
            
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the Balance for Deposit : ");
                amount =int.Parse(Console.ReadLine());
            AtmBalance = AtmBalance + amount;
            transaction.Add(amount);
        }
        public void WithDraw() 
        {
            Console.WriteLine("Enter the amount you want to WithDraw: ");
            amount = int.Parse(Console.ReadLine());
            AtmBalance = AtmBalance - amount;
            transaction.Add(amount);
        }
        public void balance()
        {
            Console.WriteLine(AtmBalance);
        }
        public void transac()
        {
            for(int i = 0; i < transaction.Count; i++)
            {
                Console.WriteLine(transaction[i]);
            }
        }




    }
}
