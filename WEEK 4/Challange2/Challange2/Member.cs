using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange2
{
    internal class Member
    {
        public Member(string name,int id,int noOfBuyBooks,float bankMoney,float spentAmount,List<string> books) 
        {
            personName = name;
            memberID = id;
            numberOfBoughtBooks = noOfBuyBooks;
            moneyInBank = bankMoney;
            amountSpent = spentAmount;
            this.books = books;
        }
        public string personName;
        public int memberID;
        public int numberOfBoughtBooks;
        public float moneyInBank;
        public float amountSpent;
        public List<string> books=new List<string>();

        public void modifyName(string name)
        {
            personName=name;
        }
        public string showName()
        {
            return personName;
        }
        public int showBoughtBooks()
        {
            return numberOfBoughtBooks;
        }
        public float showSpentAmount()
        {
            return amountSpent;
        }
        public void boughtBooksModify(int bookBought)
        {
            numberOfBoughtBooks=bookBought;
        }
        public void spentAmountModify(float amountSpent)
        {
            this.amountSpent = amountSpent;
        }
    }
}
