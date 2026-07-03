namespace VendingMachine
{
    public interface IState
    {
        void InsertCoin();
        void PressButton();
    }
}