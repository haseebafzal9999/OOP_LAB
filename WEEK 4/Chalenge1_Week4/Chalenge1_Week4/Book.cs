using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chalenge1_Week4
{
    internal class Book
    {
        public Book(string title,int noOfAuthors, List<string> author,string publisher,string ISBN,float price,int stock,string yearOfPublication)
        {
            this.title = title;
            this.noOfAuthors = noOfAuthors;
            this.author = author;
            this.publisher = publisher;
            this.ISBN = ISBN;
            this.stock = stock;
            this.price = price;
            this.yearOfPublication = yearOfPublication;

        
        }
        public string title;
        public int noOfAuthors;
        public List<string> author=new List<string>();
        public string publisher;
        public string ISBN;
        public float price;
        public int stock;
        public string yearOfPublication;
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
