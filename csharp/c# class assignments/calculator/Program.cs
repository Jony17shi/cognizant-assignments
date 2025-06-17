using System;
class Calculator
{
    static void Main()
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            if (choice == 1)
                result = num1 + num2;
            else if (choice == 2)
                result = num1 - num2;
            else if (choice == 3)
                result = num1 * num2;
            else if (choice == 4)
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero.");
            }
            else
                Console.WriteLine("Invalid choice.");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Do you want to continue? (yes/no)");
            if (Console.ReadLine().ToLower() != "yes")
                keepRunning = false;
        }
        Console.WriteLine("Calculator exited.");
    }
}
