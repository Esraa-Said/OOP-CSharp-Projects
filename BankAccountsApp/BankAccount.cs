﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            this.Owner = owner;
            this.AccountNumber = Guid.NewGuid();
            this.Balance = 0;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You can not deposit ${amount}";
            }
            if (amount > 20000)
            {
                return "AML Deposit Limit Reached";
            }
            Balance += amount;
            return "Deposite completed successfully";
        }


        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You can not withdraw ${amount}";
            }
            if (amount > Balance)
            {
                return "You don't have enough money";
            }
            Balance -= amount;
            return "Withdraw completed successfully";
        }
    
    }
}
