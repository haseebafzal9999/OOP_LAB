using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6.Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetBookName("ZainBook");
            book.SetBookId("1");
            /*For  Aggregation:-*/
            // Author author = new Author("abc","cde","fgh");
            //book.SetBookAuthor();
            /*For Composition:
              -*/
            book.SetBookAuthor("abc","cde","fgh");

            Console.WriteLine($"{book.GetBookName()} \t\t{book.GetBookid()} \t\t{book.GetAuthorName()}");
            Console.ReadKey();
        }
    }
}
