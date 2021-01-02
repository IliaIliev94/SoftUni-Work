using NUnit.Framework;
using System;
using _01._NUnit_Test;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        private _01._NUnit_Test.BankAccount bankAccount;
        [SetUp]
        public void Initialize()
        {
            bankAccount = new _01._NUnit_Test.BankAccount(5000M);
        }
        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            bankAccount.Deposit(1000M);
            Assert.That(bankAccount.Amount, Is.EqualTo(6000M));
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            bankAccount.Deposit(1000M);
            Assert.That(bankAccount.Amount, Is.EqualTo(6000M));
        }
    }
}
