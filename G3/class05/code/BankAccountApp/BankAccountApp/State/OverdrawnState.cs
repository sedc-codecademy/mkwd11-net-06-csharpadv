using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.State
{
    public class OverdrawnState : BankAccountState
    {
        public OverdrawnState(decimal balance,
                              BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;

            if (Balance >= 0) 
            {
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, cannot withdraw, balance {Balance}");
        }
    }
}
