using BankAccountApp.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance { get { return BankAccountState.Balance; } }

        public BankAccount()
        {
            BankAccountState = new RegularState(1000, this);
        }

        public void Deposit(decimal amount) 
        {
            BankAccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount) 
        {
            BankAccountState.Withdraw(amount);
        } 
    }
}
