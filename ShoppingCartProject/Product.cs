using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace ShoppingCart
{
    public class Product
    {

        public int productId { set; get; }
        public string productName { set; get; }
        public float price { set; get; }
        public float discount { set; get; }
        public int quantity { set; get; }
        static int idCounter = 0;
        static List<Product> products = new List<Product>();


        public Product(string name, float price, float discount, int quantity)
        {
            productName = name;
            idCounter++;
            productId = idCounter;
            this.price = price;
            this.discount = discount;
            this.quantity = quantity;
        }

    }
}

