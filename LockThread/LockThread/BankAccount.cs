using System;

namespace LockThread
{
    class BankAccount
    {
        private readonly object _accountLock = new object();

        private double Balance { set; get; }

        public BankAccount(double bal)     // Constructor
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if (Balance - amt < 0)
            {
                Console.WriteLine("Sorry {0} in Account", Balance);
                return Balance;
            }

            lock (_accountLock)  // keep any other thread from coming here trying to access all of the code inside lock until each thread is finished 
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in account", amt, (Balance - amt));
                    Balance -= amt;
                }

                return Balance;
            }

        }

        public void IssueWithdraw()   // each thread withdraw 1 dollar from balance
        {
            Withdraw(1);
        }
    }
}