using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Welcome to the Currency Converter!");

        // Available exchange rates (Example: Hardcoded rates)
        double usdToEur = 0.85;
        double usdToGbp = 0.76;
        double usdToInr = 74.57;

        // Choose the currency to convert from
        Console.WriteLine("\nSelect the currency you want to convert from:");
        Console.WriteLine("1. USD to EUR");
        Console.WriteLine("2. USD to GBP");
        Console.WriteLine("3. USD to INR");
        Console.Write("Enter your choice (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Get the amount in USD
        Console.Write("Enter the amount in USD: ");
        double amountInUsd = Convert.ToDouble(Console.ReadLine());

        // Perform conversion based on user choice
        double convertedAmount = 0;
        switch (choice)
        {
            case 1:
                convertedAmount = amountInUsd * usdToEur;
                Console.WriteLine($"\n{amountInUsd} USD is equal to {convertedAmount:F2} EUR.");
                break;
            case 2:
                convertedAmount = amountInUsd * usdToGbp;
                Console.WriteLine($"\n{amountInUsd} USD is equal to {convertedAmount:F2} GBP.");
                break;
            case 3:
                convertedAmount = amountInUsd * usdToInr;
                Console.WriteLine($"\n{amountInUsd} USD is equal to {convertedAmount:F2} INR.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please run the program again.");
                break;
        }

        // End program
        Console.WriteLine("\nThank you for using the Currency Converter.");
    }
}
