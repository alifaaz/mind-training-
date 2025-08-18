using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public class Order
    {

        public int orderId { set; get; }
        public int customerId { set; get; }
        public List<Product> orderProducts = new List<Product>();
        public DateTime orderDate;
        public float totalAmount;
        static int idconter = 0;

        public Order PlaceOrder(Cart cart, Customer customer, Payment payment)
        {
            if (cart.cartItems.Count == 0)
            {
                Console.WriteLine("The Cart is Empty.");
                return null;
            }
            Order order = new Order
            {
                orderId = idconter++,
                orderProducts = new List<Product>(cart.cartId),
                totalAmount = cart.cartItems.Sum(p => p.cartItems.price),
                customerId = customer.customerId,
                orderDate = DateTime.Now
            };
            Console.WriteLine($"Order {order.orderId} places sucssfully.");
            Console.WriteLine($"Total Amount : {order.totalAmount}");
            return order;
        }
        static void CancelOrder()
        {

        }
        static void TrackOrder()
        {

        }

    }
}

