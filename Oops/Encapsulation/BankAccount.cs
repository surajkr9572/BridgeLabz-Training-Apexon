using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Encapsulation
{
    internal class BankAccount
    {
        private double balance;
        private string name;
        
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        public double getBalance()
        {
            return balance;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount..");
            }
        }
        public void Widthrow(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance..");
            }
        }
    }
}
