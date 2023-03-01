using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management_System
{
    internal class Account
    {
        public string owner_name { get; set; }
        private double balance { get; set; }
        public string account_number { get; set; }

        public void deposit(double amount)
        {
            balance += amount;
            /*Console.WriteLine($"{amount} deposit has been made.");*/
        }

        public void withdraw(double amount)
        {
            if(balance < amount)
            {
                Console.WriteLine($"Withdraw failed: Balance insufficient in {owner_name}'s account");
                Console.WriteLine();
            }
            else
            {
                balance -= amount;
                /*Console.WriteLine($"{amount} withdrawn Sucessfully");*/

            }
        }

        public double getBalance()
        {
            return balance;
        }
    }
}
