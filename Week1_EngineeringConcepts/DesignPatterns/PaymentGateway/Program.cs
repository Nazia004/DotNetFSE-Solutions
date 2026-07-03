namespace PaymentGateway
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentContext payment = new PaymentContext(new CreditCardPayment());

            payment.MakePayment(2500);

            payment.SetPaymentStrategy(new UPIPayment());
            payment.MakePayment(1500);

            payment.SetPaymentStrategy(new PayPalPayment());
            payment.MakePayment(5000);
        }
    }
}
