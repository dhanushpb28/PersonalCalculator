using System.Globalization;

namespace PersonalCalculator;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to Your Personal Calculator!");
        Console.WriteLine("===================================");

        double firstNumber = ReadNumber("Please enter your first number: ");
        double secondNumber = ReadNumber("Please enter your second number: ");

        Console.WriteLine($"You entered: {firstNumber} and {secondNumber}");
        ShowOperations();

        int choice = ReadOperationChoice();
        if (!TryCalculate(firstNumber, secondNumber, choice, out double result, out string operation, out string error))
        {
            Console.WriteLine($"Error: {error}");
            return;
        }

        Console.WriteLine(
            $"\nResult: {firstNumber} {operation} {secondNumber} = {result.ToString("G15", CultureInfo.CurrentCulture)}");
        Console.WriteLine("Thank you for using the calculator!");
    }

    private static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double number) &&
                !double.IsNaN(number) &&
                !double.IsInfinity(number))
            {
                return number;
            }

            Console.WriteLine("Invalid number. Please enter a valid number.");
        }
    }

    private static int ReadOperationChoice()
    {
        while (true)
        {
            Console.Write("Enter your choice (1-5): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out int choice) &&
                choice is >= 1 and <= 5)
            {
                return choice;
            }

            Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
        }
    }

    private static void ShowOperations()
    {
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("5. Modulus (%)");
    }

    private static bool TryCalculate(
        double firstNumber,
        double secondNumber,
        int choice,
        out double result,
        out string operation,
        out string error)
    {
        result = 0;
        operation = string.Empty;
        error = string.Empty;

        switch (choice)
        {
            case 1:
                result = firstNumber + secondNumber;
                operation = "+";
                return true;
            case 2:
                result = firstNumber - secondNumber;
                operation = "-";
                return true;
            case 3:
                result = firstNumber * secondNumber;
                operation = "*";
                return true;
            case 4:
                if (secondNumber == 0)
                {
                    error = "Division by zero is not allowed.";
                    return false;
                }

                result = firstNumber / secondNumber;
                operation = "/";
                return true;
            case 5:
                if (secondNumber == 0)
                {
                    error = "Modulus by zero is not allowed.";
                    return false;
                }

                result = firstNumber % secondNumber;
                operation = "%";
                return true;
            default:
                error = "Invalid choice. Please select a valid operation.";
                return false;
        }
    }
}
