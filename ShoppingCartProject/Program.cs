using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product("panan", 4, 0, 500);
            Product product2 = new Product("tols", 3, 0, 100);
            Product product3 = new Product("cat", 2, 0, 120);
            Product product4 = new Product("aple", 6, 0, 200);
            Admin admin = new Admin();
            admin.userName = "Rabab";
            admin.userPassword = "666";
            admin.AddProduct(product1);
            admin.AddProduct(product2);
            admin.AddProduct(product3);
            admin.AddProduct(product4);
            Console.WriteLine("-------------------The Products in My Store---------------");
            admin.GetDetails();
            Customer customer = new Customer();
            customer.userName = "Ahmad";
            customer.userPassword = "123";


            // customer.LogIn("07712345678", "12345678");
            Console.WriteLine("1-CreatAccount");
            Console.WriteLine("2-LogIn");
            Console.WriteLine("Enter Choice");

            string input = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter valid number.");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        customer.CreateAccount();
                        break;
                    case 2:
                        Console.WriteLine("enter phone number");
                        string phone = Console.ReadLine();
                        Console.WriteLine("enter phone password");
                        string password = Console.ReadLine();
                        customer.LogIn(phone, password);
                        break;
                }
            }
            var productCatalog = new Dictionary<int, Product>
            {
                {1,product1},
                {2,product2},
                {3,product3},
                {4,product4}
            };
            bool continueShopping = true;
            while (continueShopping)
            {
                Console.WriteLine("What product want add to cart?");
                foreach (var item in productCatalog)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.productName}");
                }
                if (!int.TryParse(Console.ReadLine(), out choice) || !productCatalog.ContainsKey(choice) || !int.TryParse(Console.ReadLine(), out int qun))
                {
                    continue;
                }
                Product selectProduct = productCatalog[choice];
                customer.customercart.AddItemToCart(selectProduct, qun);
                Console.WriteLine("Add another product?Yes/No");
                string response = Console.ReadLine()?.Trim().ToLower();
                continueShopping = response == "yes" || response == "y";
            }
            Console.WriteLine("------------cart items------------");
            customer.customercart.ViewCart();
            Console.WriteLine("remove items?y/n");

            Product selectProduct2 = productCatalog[choice];
            customer.customercart.RemoveItem(selectProduct2.productId);
            customer.customercart.ViewCart();
            // Console.WriteLine("What product want add to cart?");
            // string input2 = Console.ReadLine();
            // if (!int.TryParse(input2, out choice))
            // {
            //     Console.WriteLine("enter valid product number.");

            // }
            // else
            // {
            //     Console.WriteLine("Enter Quantity:");
            //     if (!int.TryParse(Console.ReadLine(), out int qun) || qun <= 0)
            //     {
            //         Console.WriteLine("enter valid quantity.");
            //         return;
            //     }
            //     switch (choice)
            //     {
            //         case 1:
            //             Console.WriteLine("enter quantety");
            //             customer.customercart.AddItemToCart(product1, qun);
            //             break;
            //         case 2:
            //             Console.WriteLine("enter quantety");
            //             customer.customercart.AddItemToCart(product2, qun);
            //             break;
            //         case 3:
            //             Console.WriteLine("enter quantety");
            //             customer.customercart.AddItemToCart(product3, qun);
            //             break;
            //         case 4:
            //             Console.WriteLine("enter quantety");
            //             customer.customercart.AddItemToCart(product4, qun);
            //             break;
            //         default:
            //             Console.WriteLine("Invalid product number");
            //             break;
            //     }
            // }
            // Console.WriteLine("Do you want add another product?");
            // Console.WriteLine("1-Yes.");
            // Console.WriteLine("2-No");
            // string input3 = Console.ReadLine();


            // Console.WriteLine("1-Show Cart");
            // Console.WriteLine("2-add producr");




        }
    }
}