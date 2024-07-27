using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Week4.Challenge2
{
    internal class Member
    {
        public string Name;
        public string MemberID;

        public List<string> BuyBook = new List<string>();
        public int MoneyInBank;
        public int AmountSpent;

        public Member(string name, string memberID, List<string> buyBook, int moneyInBank, int amountSpent)
        {
            Name = name;
            MemberID = memberID;
            BuyBook = buyBook;
            MoneyInBank = moneyInBank;
            AmountSpent = amountSpent;
        }
        public Member(string name , string memberID)
        {
            Name=name;
            MemberID = memberID;

        }
    }
}
