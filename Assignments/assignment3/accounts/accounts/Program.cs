using System;

namespace Accounts
{

    public class Accounts
    {
        private int AccountNo;
        private string Customername;
        private string Accounttype;
        private char Transactiontype;
        private double Balance;

        public Accounts(int AccountNo, string Customername, string Accounttype, char Transactiontype, double amount)
        {
            this.AccountNo = AccountNo;
            this.Customername = Customername;
            this.Accounttype = Accounttype;
            this.Transactiontype = Transactiontype;
            this.Balance = 0;
            UpdateBalance(amount);
        }

        public void UpdateBalance(double amount)
        {
            if (Transactiontype == 'd')
            {
                Credit(amount);
            }
            else if (Transactiontype == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type");
                Console.ReadLine();
            }
        }

        public void Credit(double amount)
        {

            this.Balance = Balance + amount;
            Console.WriteLine("Amount credited");
            Console.ReadLine();
        }

        public void Debit(double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                Console.WriteLine("Amount debited");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Console.ReadLine();
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Account No   : {AccountNo}");
            Console.WriteLine($"Customer Name: {Customername}");
            Console.WriteLine($"Account Type : {Accounttype}");
            Console.WriteLine($"Balance      : {Balance}");
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Accounts account1 = new Accounts(2000, "Pooja Kulkarni", "Savings", 'd', 1000);
            account1.ShowData();

            Accounts account2 = new Accounts(2001, "Girish Kulkarni", "Current", 'w', 500);
            account2.ShowData();
        }
    }
}