using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acess_specifier
{
    using System;

    public class BankAccount
    {
        // Private field accessible only within the class
        private string accountNumber;

        // Public property with private setter and public getter
        public string AccountHolderName { get; private set; }

        // Public property with private getter and public setter
        public double Balance { get; private set; }

        // Public constructor to initialize account holder name and account number
        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            Balance = 0;
        }

        // Public method to deposit funds into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Public method to withdraw funds from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        // Private method accessible only within the class
        private void GenerateAccountStatement()
        {
            Console.WriteLine($"Account Statement for {AccountHolderName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: ${Balance}");
        }

        // Public method to display account information
        public void DisplayAccountInfo()
        {
            GenerateAccountStatement();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Samruddhi", "1234567890");

            account.Deposit(10000);
            account.Withdraw(2300);

            account.DisplayAccountInfo();
            Console.ReadLine();

        }
    }

}
