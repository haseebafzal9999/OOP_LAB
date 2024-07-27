using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek4.Task1
{
    internal class customer
    {
        public string CustomerName;
        public string CustomerAdress;
        public string CustomerContact;
        public List<product> products = new List<product>();
        public List<product> getAllProducts()
        {
            return products;
        }
        public addProduct(product p)
        {
            products.Add(p);
        }

    }
}
