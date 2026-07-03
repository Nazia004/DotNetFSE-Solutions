using System;

namespace PaymentGateway
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using PayPal.");
        }
    }
}