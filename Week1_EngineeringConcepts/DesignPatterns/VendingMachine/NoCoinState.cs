using System;

namespace VendingMachine
{
    public class NoCoinState : IState
    {
        private readonly VendingMachine vendingMachine;

        public NoCoinState(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin inserted.");
            vendingMachine.SetState(vendingMachine.HasCoinState);
        }

        public void PressButton()
        {
            Console.WriteLine("Please insert a coin first.");
        }
    }
}