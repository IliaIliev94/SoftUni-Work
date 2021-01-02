using System;
using System.Collections.Generic;
using System.Text;

namespace _01._NUnit_Test
{
    public class BankAccount
    {
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Amount must be positive.");
                }
                this.amount = value;
            }
        }

        public BankAccount(decimal initialAmount)
        {
            this.Amount = initialAmount;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            this.Amount += amount;
        }
    }
}
