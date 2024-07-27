using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Challenge1.BL
{
    internal class CredentialBL
    {
        public CredentialBL(string x, string y, string z)
        {
            userName = x;
            userpassword = y;
            userrole = z;
        }
        public CredentialBL(string x, string y)
        {
            userName = x;
            userpassword = y;

        }
        public CredentialBL()
        {
        }

        public string userName;
        public string userpassword;
        public string userrole;

    }
}
