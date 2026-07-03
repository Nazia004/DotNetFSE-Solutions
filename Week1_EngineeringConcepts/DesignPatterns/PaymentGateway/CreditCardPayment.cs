using System;

namespace PaymentGateway
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Credit Card.");
        }
    }
}