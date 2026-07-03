namespace VendingMachine
{
    public class VendingMachine
    {
        public IState NoCoinState { get; }
        public IState HasCoinState { get; }

        private IState currentState;

        public VendingMachine()
        {
            NoCoinState = new NoCoinState(this);
            HasCoinState = new HasCoinState(this);

            currentState = NoCoinState;
        }

        public void SetState(IState state)
        {
            currentState = state;
        }

        public void InsertCoin()
        {
            currentState.InsertCoin();
        }

        public void PressButton()
        {
            currentState.PressButton();
        }
    }
}