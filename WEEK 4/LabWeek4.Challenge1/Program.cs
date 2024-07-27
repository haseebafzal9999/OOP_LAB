using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek4.Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Book book = new Book();
            List<Book> list = new List<Book>();
            List<string> author = new List<string>();

            int value = 1;
            while(value !=0)
            {
                Console.Clear();
                option = mainMenu();
                if(option== 1)
                {
                    AddBook(list ,author);
                }
                else if (option == 2)
                {
                    string title;
                    Console.Write("Enter Book Name: ");
                    title = Console.ReadLine();
                    Book SearchedBook = SearchByTitle(title, list);
                    Console.WriteLine("Title\tISBN\tStock\tAuthor");
                    if (SearchedBook != null)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", SearchedBook.title, SearchedBook.ISBN, SearchedBook.stock, SearchedBook.Author[0]);
                    }
                }
                else if (option == 3)
                {
                    string ISBN;
                    Console.Write("Enter ISBN of Book: ");
                    ISBN = Console.ReadLine();
                    Book SearchedBookISBN = SearchByTitle(ISBN, list);
                    Console.WriteLine("Title\tISBN\tStock\tAuthor");
                    if (SearchedBookISBN != null)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", SearchedBookISBN.title, SearchedBookISBN.ISBN, SearchedBookISBN.stock, SearchedBookISBN.Author[0]);
                    }
                }
                else if (option == 4)
                {
                    string title;
                    int copies;
                    Console.Write("Enter Book Name to update copies: ");
                    title = Console.ReadLine();
                    int index = searchBookCountByTitle(title, list);
                    if (list[index] != null)
                    {
                        Console.Write("Enter No of Updated Copies: ");
                        copies = int.Parse(Console.ReadLine());
                        list[index].updateCopies(copies);
                    }
                    else
                    {
                        Console.WriteLine("Enter correct input.");
                    }
                }
                else if (option == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Enter valid option.");
                }
                Console.ReadKey();
            }

        }
        static int mainMenu()
        {
            int option;
            Console.WriteLine("1) Add a Book:");
            Console.WriteLine("2) Search a book by its title:");
            Console.WriteLine("3) Search by ISBN:");
            Console.WriteLine("4) Update the number of copies of book:");
            Console.WriteLine("Enter the Option");
            option=int.Parse(Console.ReadLine());
            return option;
        }

        static void AddBook(List<Book> list , List<string> author)
        {
            int Stock, Price, Year, AuthorNo;
            string title, ISBN, Publisher,Author;
            Console.WriteLine("Enter the title of Book:");
            title = Console.ReadLine();
            Console.WriteLine("Enter the Name of Publisher:");
            Publisher = Console.ReadLine();
            Console.WriteLine("Enter the Number of Author of Book(1/2/3/4):");
            AuthorNo = int.Parse(Console.ReadLine());
            for(int i=0; i< AuthorNo; i++)
            {
                Console.WriteLine("Enter the Author of Book:");
                Author = Console.ReadLine();
                author.Add(Author);
            }
            Console.WriteLine("Enter the Stock of Book:");
            Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ISBN of Book:");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter the Price of Book:");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year of Publication  of Book:");
            Year = int.Parse(Console.ReadLine());
            Book newBook= new Book(title, Publisher, AuthorNo, author,Stock,ISBN ,Price ,Year);
            list.Add(newBook);
        }
        static Book SearchByTitle(string title,List<Book> list)
        {
            Console.WriteLine("Enter the title:");
                title= Console.ReadLine();
            for(int i=0; i< list.Count; i++)
            {
                if (list[i].title == title)
                {
                    return list[i];
                }
            }
            return null;
        }
        static Book SearchByISBN(string ISBN, List<Book> list)
        {
            Console.WriteLine("Enter the title:");
            ISBN = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ISBN == ISBN)
                {
                    return list[i];
                }
            }
            return null;
        }
        static int searchBookCountByTitle(string title, List<Book> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].title == title)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
