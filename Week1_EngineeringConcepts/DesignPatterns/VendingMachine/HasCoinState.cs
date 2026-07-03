using System;

namespace VendingMachine
{
    public class HasCoinState : IState
    {
        private readonly VendingMachine vendingMachine;

        public HasCoinState(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin already inserted.");
        }

        public void PressButton()
        {
            Console.WriteLine("Dispensing item...");
            vendingMachine.SetState(vendingMachine.NoCoinState);
        }
    }
}