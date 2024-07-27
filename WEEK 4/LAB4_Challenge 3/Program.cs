using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            List<Member> members = new List<Member>();

            Book book = new Book();
            List<Book> list = new List<Book>();
            List<BuyProduct> buy = new List<BuyProduct>();
            BuyProduct B = new BuyProduct();
            List<string> author = new List<string>();
            float UserBill = 0;

            int value = 1;
            while (value != 0)
            {
                Console.Clear();
                option = mainMenu();
                if (option == 1)
                {
                    AddBook(list, author);
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
                        Console.WriteLine("{0}\t{1}\t{2}", SearchedBook.title, SearchedBook.ISBN, SearchedBook.stock);
                    }
                }
                else if (option == 3)
                {
                    string ISBN;
                    Console.Write("Enter ISBN of Book: ");
                    ISBN = Console.ReadLine();
                    Book SearchedBookISBN = SearchByISBN(ISBN, list);
                    Console.WriteLine("Title\tISBN\tStock\tAuthor");
                    if (SearchedBookISBN != null)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", SearchedBookISBN.title, SearchedBookISBN.ISBN, SearchedBookISBN.stock);
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
                else if (option == 5)
                {
                    AddMember(members);
                }
                else if (option == 6)
                {
                    SearchMember(members);
                }
                else if (option == 7)
                {
                    Update_Information(members);
                }
                else if (option == 8)
                {
                    B.PurchaseBook(list, UserBill, buy);
                }
                else if (option == 9)
                {
                    ViewMember(members);
                }
                else if (option == 10)
                {
                    break;
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
            Console.WriteLine("5) Add Member:");
            Console.WriteLine("6) Search for a Member by Name or ID:");
            Console.WriteLine("7) Update Member Information");
            Console.WriteLine("8)  Purchase a Book:");
            Console.WriteLine("9)   Display Total Sales and Membership Stats:");
            Console.WriteLine("10)  Exit:");
            Console.WriteLine("Enter the Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
      static void ViewMember(List<Member> members)
        {
            Console.WriteLine("Member Name \t\t MemberID");
            for(int i=0; i<members.Count; i++)
            {
                Console.WriteLine($"{members[i].Name}\t\t{members[i].MemberID}");
            }
        }

       
        static void AddBook(List<Book> list, List<string> author)
        {
            int Stock, Price, Year, AuthorNo;
            string title, ISBN, Publisher, Author;
            Console.WriteLine("Enter the title of Book:");
            title = Console.ReadLine();
            Console.WriteLine("Enter the Name of Publisher:");
            Publisher = Console.ReadLine();
            Console.WriteLine("Enter the Number of Author of Book(1/2/3/4):");
            AuthorNo = int.Parse(Console.ReadLine());
            for (int i = 0; i < AuthorNo; i++)
            {
                Console.WriteLine("Enter the Author of Book:");
                Author = Console.ReadLine();
                author.Add(Author);
            }
            Console.WriteLine("Enter the ISBN of Book:");
            Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ISBN of Book:");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter the Price of Book:");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year of Publication  of Book:");
            Year = int.Parse(Console.ReadLine());
            Book newBook = new Book(title, Publisher, AuthorNo, author, Stock, ISBN, Price, Year);
            list.Add(newBook);
        }
        static Book SearchByTitle(string title, List<Book> list)
        {
            Console.WriteLine("Enter the title:");
            title = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
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
        static void AddMember(List<Member> members)
        {
            string name, MemberID;
            Console.WriteLine("Enter The Member Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter The Member Name:");
            MemberID = Console.ReadLine();
            Member m1 = new Member(name, MemberID);
            members.Add(m1);
        }
        static void SearchMember(List<Member> members)
        {
            string Name;
            int index = 0;
            Console.WriteLine("Enter Member Name:");
            Name = Console.ReadLine();
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name == Name)
                {
                    index = i;
                }
                else
                {
                    Console.WriteLine("This Member is Not in BookStore Data: ");
                }

            }
            Console.WriteLine($" Name:\t {members[index].Name}");
            Console.WriteLine($" Name:\t {members[index].MemberID}");

        }
        static void Update_Information(List<Member> members)
        {
            string Name;
            string nam;
            string ID;
            int index = 0;
            Console.WriteLine("Enter Member Name  :");
            Name = Console.ReadLine();
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name == Name)
                {

                    index = i;
                }
                else
                {
                    Console.WriteLine("This Member is Not in BookStore Data: ");
                }
                Console.WriteLine("Enter the Update Name:");
                nam = Console.ReadLine();
                members[index].Name = nam;
                Console.WriteLine("Enter the Update MemberID:");
                ID = Console.ReadLine();
                members[index].MemberID = ID;
                Console.WriteLine("Name and ID Update Successfully..");
                Console.ReadKey();
            }



        }
    }
}
