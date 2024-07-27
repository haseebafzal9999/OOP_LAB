using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6.Challenge1
{
    internal class Author
    {
        private string Name;
        private string Email;
        private string Location;
        public Author()
        { }
        public Author(string name, string email, string location)
        {
            Name = name;
            Email = email;
            Location = location;
        }
        public void SetAuthorName(string AuthorName)
        {
            AuthorName = Name;
        }
        public void SetAuthorEmail(string email)
        {
            this.Email = email;
        }
        public void SetAuthorlocation(string location)
        {
            Location = location;
        }
        public string GetAuthorName()
        {
            return Name;
        }
        public string GetAuthorEmail()
        {
            return this.Email;
        }
        public string GetLocation()
        {
            return this.Location;
        }

    }
}
