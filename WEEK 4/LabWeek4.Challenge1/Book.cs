using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek4.Challenge1
{
    internal class Book
    {
        public string title;
        public string Publisher;
        public int authorNO;
        public List<string> Author=new List<string>();
        public int stock;
        public string ISBN;
        public int Price;
        public int YearOfPub;
        public Book(string title, string Publisher, int authorNO,List<string> Author , int stock, string ISBN, int Price, int YearOfPub)
        {
            this.title = title;
            this.Publisher = Publisher;
            this.authorNO = authorNO;
            this.Author = Author;
            this.stock = stock;
            this.ISBN = ISBN;
            this.Price = Price;
            this.YearOfPub = YearOfPub;     
        }
        public Book()
        {

        }
        public void updateCopies(int copies)
        {
            if (copies > 0)
            {
                stock = copies;
            }
            else
            {
                Console.WriteLine("Enter valid number.");
            }
        }


        }
}
