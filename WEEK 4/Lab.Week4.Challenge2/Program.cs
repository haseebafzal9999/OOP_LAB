using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Week4.Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            int option = 1;
            int value = 1;
            while( option != 0 )
            {
                Console.Clear();    
                value = Menu();
                if ( value == 1 )
                {
                    AddMember(members);
                }
                else if(value ==2)
                {
                    SearchMember(members);
                }
                else if (value == 3)
                {
                    Update_Information(members);
                }
                else if(value == 4)
                {
                    break;
                }
            }

        }
        static int Menu()
        {
            int option;
            Console.WriteLine("Enter the option:");
            Console.WriteLine("1 Add Member:");
            Console.WriteLine("2 Search for a Member by Name or ID:");
            Console.WriteLine("3 Update Member Information");
            Console.WriteLine("4  Purchase a Book:");
            Console.WriteLine("5   Display Total Sales and Membership Stats:");
            Console.WriteLine("6  Exit:");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void AddMember(List<Member> members)
        {
            string name, MemberID;
            Console.WriteLine("Enter The Member Name:");
            name= Console.ReadLine();
            Console.WriteLine("Enter The Member Name:");
            MemberID = Console.ReadLine();
            Member m1=new Member(name , MemberID);
            members.Add(m1 );
        }
        static void SearchMember(List<Member> members)
        {
            string Name;
            int index=0;
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
                nam= Console.ReadLine();
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
