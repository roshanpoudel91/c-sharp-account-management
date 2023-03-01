using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management_System
{
    internal static class AccountManager
    {
        static List<Account> accounts = new List<Account>();   

        public static void addAccount(Account account)
        {
            accounts.Add(account);
        }

        public static void displayAccounts()
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine("Owner Name: {0}",account.owner_name);
                Console.WriteLine("Account Number: {0}",account.account_number);
                Console.WriteLine("Account Balance: {0}",account.getBalance());
                Console.WriteLine();
            }
        }
    }
}
