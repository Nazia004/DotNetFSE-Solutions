namespace PaymentGateway
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}