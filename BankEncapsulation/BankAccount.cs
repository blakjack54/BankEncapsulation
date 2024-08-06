using System;

namespace BankApp
{
    public class BankAccount
    {
        // Private field to store the balance
        private double balance = 0;

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to retrieve the current balance
        public double GetBalance()
        {
            return balance;
        }
    }
}