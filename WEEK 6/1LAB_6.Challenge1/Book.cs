using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6.Challenge1
{
    internal class Book
    {
        private string Name;
        private string BookId;
        private Author author =new Author();


        public void SetBookName(string name)
        {
            this.Name = name;
        }
        public string GetBookName()
        {
            return this.Name;
        }
        public void SetBookId(string bookId)
        {
            this.BookId = bookId;
        }
        public string GetBookid()
        {
            return this.BookId;
        }
        /* For Aggregation::-
         * public void SetBookAuthor(Author author)
          {
              this.author = author;
          }*/
             /*For Composition::-*/
          public void SetBookAuthor(string name ,string email ,string location)
          {
              author = new Author(name , email , location);
          }
        public string GetAuthorName()
        {
            return author.GetAuthorName();
        }


    }
}
