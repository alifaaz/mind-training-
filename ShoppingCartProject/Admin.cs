using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public class Admin : User
    {

        public int adminId { set; get; }
        public int customerId { set; get; }
        public List<Product> products = new List<Product>();
        public int idCounter = 0;

        public Admin()
        {
            idCounter++;
            adminId = idCounter;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            products.RemoveAll(p => p.productId == productId);
        }
        public void GetDetails()
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Id : {product.productId} Name:{product.productName} Price:{product.price} Discount:{product.discount} Quantity:{product.quantity}");
            }
        }
    }
}