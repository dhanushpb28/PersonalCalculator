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

            //Operation selection
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Modulus (%)");
            Console.Write("Enter your choice (1-5): ");

            int choice=Convert.ToInt32(Console.ReadLine());
            double result=0;
            string operation="";
            if(choice==1)
            {
                result=firstNumber+secondNumber;
                operation="+";
            
            }
            else if(choice==2)
            {
                result=firstNumber-secondNumber;
                operation="-";
            }
            else if(choice==3)
            {
                result=firstNumber*secondNumber;
                operation="*";
            }
            else if(choice==4)
            {
                if(secondNumber!=0)
                {
                    result=firstNumber/secondNumber;
                    operation="/";
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return; // Exit the program
                }
            }
            else if(choice==5)
            {
                result=firstNumber%secondNumber;
                operation="%";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                return; // Exit the program
            }
            Console.WriteLine($"\nResult: {firstNumber} {operation} {secondNumber} = {result}");
            Console.WriteLine("Thank you for using the calculator!");
            Console.ReadLine(); // Keep console open
        }
    }
}