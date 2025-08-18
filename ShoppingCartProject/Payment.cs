using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ShoppingCart
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        PayPal,
        BankTransfer
    }
    public enum PaymentState
    {
        Pending,
        Completed,
        Failed,
        Cancelled,
        Refunded
    }
    public class Payment
    {

        public int PaymentId;
        public PaymentMethod paymentMethod { set; get; }
        public int orderId { set; get; }
        public DateTime paymentDate { set; get; }
        public double amount { set; get; }
        static int idCounter = 0;
        public PaymentState paymentState { get; set; }

        public Payment()
        {

            idCounter++;
            PaymentId = idCounter;
        }
        public void ProcessPayment(double Amount, PaymentMethod paymentMethod)
        {
            Console.WriteLine($"Payment method: {paymentMethod}");
            Console.WriteLine($"Payment amount: {Amount}");
            if (amount <= 0)
            {
                paymentState = PaymentState.Failed;
                Console.WriteLine("Invalid amount.");
                return;
            }
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    Console.WriteLine("Paid by cash successfully");
                    break;
                case PaymentMethod.CreditCard:
                    Console.WriteLine("Paid by CreditCard successfully");
                    break;
                case PaymentMethod.PayPal:
                    Console.WriteLine("Paid by PayPal successfully");
                    break;
                default:
                    Console.WriteLine("Unknown payment method.");
                    break;
            }
            paymentState = PaymentState.Completed;
            amount = Amount;
            paymentDate = DateTime.Now;
        }
        public void RefundPayment()
        {
            if (paymentState == PaymentState.Completed)
            {
                paymentState = PaymentState.Refunded;
                Console.WriteLine($"the {amount}is Refunded");
            }
            else
            {
                Console.WriteLine("Payment is not completed.");
            }

        }

    }
}

