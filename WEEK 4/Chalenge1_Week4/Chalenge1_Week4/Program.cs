using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chalenge1_Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
           
            Start:
            int option = mainMenu();
            if (option == 1)
            {
                int noOfAuthors;
                 string title;
                 List<string> author = new List<string>();
                 string publisher;
                 string ISBN;
                 float price;
                 int stock;
                 string yearOfPublication;
                 Console.Write("Enter Book Name: ");
                title= Console.ReadLine();
                 Console.Write("Enter no of Authors of Book(1/2/3/4): ");
                noOfAuthors=int.Parse(Console.ReadLine());
                for (int i = 0; i < noOfAuthors; i++)
                {
                    Console.Write("Enter Author Name: ");
                    author.Add(Console.ReadLine());
                }
                Console.Write("Enter Publisher Name: ");
                publisher= Console.ReadLine();
                Console.Write("Enter ISBN of Book: ");
                ISBN=Console.ReadLine();
                Console.Write("Enter Price of Book: ");
                price=float.Parse(Console.ReadLine());
                Console.Write("Enter Stock of Book: ");
                stock=int.Parse(Console.ReadLine());
                Console.Write("Enter Year of Publication: ");
                yearOfPublication=Console.ReadLine();
                Book newBook=new Book(title,noOfAuthors, author, publisher,ISBN,price, stock,yearOfPublication);
                books.Add(newBook);
                Console.WriteLine("Book Added Successfully.");
            }
            else if (option == 2)
            {
                string title;
                Console.Write("Enter Book Name: ");
                title = Console.ReadLine();
                Book SearchedBook = searchBookByTitle(title, books);
                Console.WriteLine("Title\tISBN\tStock\tAuthor");
                if (SearchedBook != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}",SearchedBook.title, SearchedBook.ISBN, SearchedBook.stock, SearchedBook.author[0]);
                }
            }
            else if (option == 3)
            {
                string ISBN;
                Console.Write("Enter ISBN of Book: ");
                ISBN = Console.ReadLine();
                Book SearchedBookISBN = searchBookByISBN(ISBN, books);
                Console.WriteLine("Title\tISBN\tStock\tAuthor");
                if (SearchedBookISBN != null)
                {
                    Console.WriteLine("{0}   {1}    {2}    {3}",SearchedBookISBN.title, SearchedBookISBN.ISBN, SearchedBookISBN.stock, SearchedBookISBN.author[0]);
                }
            }
            else if (option == 4)
            {
                string title;
                int copies;
                Console.Write("Enter Book Name to update copies: ");
                title= Console.ReadLine();
                int index= searchBookCountByTitle(title, books);
                if (books[index] != null)
                {
                    Console.Write("Enter No of Updated Copies: ");
                    copies = int.Parse(Console.ReadLine());
                    books[index].updateCopies(copies);
                }
                else
                {
                    Console.WriteLine("Enter correct input.");
                }
            }
            else if(option == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Enter valid option.");
            }
            Console.ReadKey();
            goto Start;
        }

        static Book searchBookByTitle(string title, List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title)
                {
                    return books[i];
                }
            }
            return null;
        }
        static int searchBookCountByTitle(string title, List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title)
                {
                    return i;
                }
            }
            return -1;
        }
        static Book searchBookByISBN(string title, List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == title)
                {
                    return books[i];
                }
            }
            return null;
        }
        static int mainMenu()
        {
            Console.Clear();
            Console.WriteLine("1.  Add Books.");
            Console.WriteLine("2.  Search Book By Title.");
            Console.WriteLine("3.  Search Book By ISBN.");
            Console.WriteLine("4.  Update No of Copies of Book.");
            Console.WriteLine("0.  Exit.");
            Console.WriteLine("Enter Your Option: ");
            int value=int.Parse(Console.ReadLine());
            return value;
        }
    }
}
