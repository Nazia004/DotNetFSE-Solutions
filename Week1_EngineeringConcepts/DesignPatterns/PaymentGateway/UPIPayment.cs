using System;

namespace PaymentGateway
{
    public class UPIPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using UPI.");
        }
    }
}