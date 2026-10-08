using System;
namespace PersonalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Your Personal Calculator!");
            Console.WriteLine("===================================");
            
            // TODO: Add your calculator logic here

            Console.WriteLine("Please enter your first number:");
            // TODO: Get first number and convert to double
            double firstNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            // TODO: Get second number and convert to double
            double secondNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You entered: {firstNumber} and {secondNumber}");
            
            Console.WriteLine("Thank you for using the calculator!");
            Console.ReadLine(); // Keep console open
        }
    }
}