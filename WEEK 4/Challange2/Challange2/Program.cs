using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            books.Add("Bale");
            books.Add("Jibril");
            Member member=new Member("Ali",123,books.Count,12000,2000,books);
            member.modifyName("Hamza");
            Console.WriteLine(member.showName());
            member.boughtBooksModify(12);
            Console.WriteLine(member.showBoughtBooks());
            member.spentAmountModify(3000);
            Console.WriteLine(member.showSpentAmount());
            Console.ReadKey();
        }
    }
}
