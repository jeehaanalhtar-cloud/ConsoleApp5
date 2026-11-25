using System;

class Program
{
    static void Main()
    {
        double balance = 1000.0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Simple ATM System ===");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string? input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Current Balance: {balance:F2}");
                    break;

                case 2:
                    Console.Write("Enter deposit amount: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Deposited successfully. New Balance: {balance:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Deposit amount must be greater than zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                    {
                        if (withdrawAmount <= 0)
                        {
                            Console.WriteLine("Withdrawal amount must be greater than zero.");
                        }
                        else if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"Withdrawn successfully. Remaining Balance: {balance:F2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                    break;
            }
        }
    }
}
