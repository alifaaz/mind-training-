using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public class CartItems
    {
        public Product cartItems { set; get; }
        public int quntityItim { set; get; }

        public CartItems(Product product, int Qn)
        {
            cartItems = product;
            quntityItim = Qn;
        }
    }
    public class Cart
    {

        public int cartId { set; get; }
        public int customerId { set; get; }
        public List<CartItems> cartItems = new List<CartItems>();
        static int cartconter = 0;

        public Cart()
        {
            cartconter++;
            cartId = cartconter;
        }
        public void AddItemToCart(Product product, int quntityItim)
        {
            if (quntityItim <= product.quantity)
            {
                product.quantity = product.quantity - quntityItim;
                cartItems.Add(new CartItems(product, quntityItim));
            }
            else
            {
                Console.WriteLine("The product is out of stock.");
            }
        }
        public void RemoveItem(int productId)
        {
            cartItems.RemoveAll(p => p.cartItems.productId == productId);
        }

        public double GetTotalAmount()
        {
            double totalamount = 0;
            foreach (var item in cartItems)
            {
                totalamount += item.cartItems.price * item.quntityItim;
            }
            return totalamount;
        }
        public void ViewCart()
        {
            foreach (var item in cartItems)
            {
                Console.WriteLine($"ID: {item.cartItems.productId} Name: {item.cartItems.productName} Price: {item.cartItems.price} Quantity: {item.quntityItim}");
            }
            Console.WriteLine($"The Total Price is: " + GetTotalAmount());
        }

    }
}