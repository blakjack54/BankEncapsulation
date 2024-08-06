using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the BankAccount class
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("\nWelcome to the BankApp!");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            account.Deposit(amount);
                            Console.WriteLine($"Deposited: ${amount}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Current Balance: ${account.GetBalance()}");
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using BankApp. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 3.");
                        break;
                }
            }
        }
    }
}