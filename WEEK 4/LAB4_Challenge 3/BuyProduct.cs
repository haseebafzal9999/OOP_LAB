using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Challenge_3
{
    internal class BuyProduct
    {
        public string ProductName;
        public int Quantity;

        public BuyProduct(string ProductName, int Quantity)
        {
            this.ProductName = ProductName;
            this.Quantity = Quantity;
        }
        public BuyProduct() { }
        static void viewBook(List<Book> list)
        {
            Console.WriteLine($" Book Name\tBook Price\tBook Stock\tBook YearOfPublish   ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i].title}\t{list[i].Price}\t{list[i].stock}\t{list[i].YearOfPub}  ");
            }
            Console.ReadKey();
        }
        public  void PurchaseBook(List<Book> list, float UserBill, List<BuyProduct> buy)
        {
            string option = "1";
            Console.Clear();
            string productName;
            int quantity;
            BuyProduct b1 = new BuyProduct();
            float BILL = 0.0f;

            while (option == "1")
            {
                viewBook(list);
                Console.Write("Enter the product you want to buy: ");
                productName = Console.ReadLine();
                int productIndex = -1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].title == productName)
                    {
                        productIndex = i;
                        break;
                    }

                }
                if (productIndex != -1 && list[productIndex].stock > 0)
                {
                    Console.Write("Enter the quantity of product you want to buy: ");
                    quantity = int.Parse(Console.ReadLine());
                    if (quantity > 0 && quantity <= list[productIndex].stock)
                    {
                        BILL = list[productIndex].Price * quantity;
                        UserBill += BILL;
                        list[productIndex].stock -= quantity;
                        b1.ProductName = productName;
                        b1.Quantity = quantity;
                        buy.Add(b1);
                        
                        Console.WriteLine($"\n{quantity} {productName}(s) added to your cart successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity or not enough stock available.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product selection or out of stock.");
                }

                Console.WriteLine("\nEnter 1 to add product in cart or 0 to go back.");
                option = Console.ReadLine();
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"The bill is {UserBill}");
            Console.WriteLine("-------------------------------------------------------------------------------");

        }
    }
   
}
