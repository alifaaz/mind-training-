using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public class Customer : User
    {
        public int customerId { set; get; }
        static int idCounter = 0;
        public Cart customercart = new Cart();

        public Customer()
        {
            idCounter++;
            customerId = idCounter;
        }

    }
}

