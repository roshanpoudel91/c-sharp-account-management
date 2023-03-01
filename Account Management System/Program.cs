namespace Account_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account roshan = new Account() { account_number = "123456789", owner_name = "Roshan Poudel" };
            AccountManager.addAccount(roshan);
            roshan.deposit(100);
            roshan.deposit(200);
            roshan.withdraw(50);

            Account rakesh = new Account() { account_number = "456789012", owner_name = "Rakesh Jaiswal" };
            AccountManager.addAccount(rakesh);
            rakesh.deposit(1000);
            rakesh.deposit(5000);
            rakesh.withdraw(300);

            Account hemant = new Account() { account_number = "564789564", owner_name = "Hemant Chauhan" };
            AccountManager.addAccount(hemant);
            hemant.deposit(5000);
            hemant.deposit(6000);
            hemant.withdraw(20000);

            AccountManager.displayAccounts();

        }
    }
}