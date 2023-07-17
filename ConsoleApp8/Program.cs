using System;

public class Calculator : ICalculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();

        Console.WriteLine("Welcome to the Console Calculator!");
        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1/2/3/4/5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
                break;

            if (int.TryParse(choice, out int operation) && operation >= 1 && operation <= 4)
            {
                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid integer.");
                    continue;
                }

                int result = 0;
                switch (operation)
                {
                    case 1:
                        result = calculator.Add(num1, num2);
                        break;
                    case 2:
                        result = calculator.Subtract(num1, num2);
                        break;
                    case 3:
                        result = calculator.Multiply(num1, num2);
                        break;
                    case 4:
                        try
                        {
                            result = calculator.Divide(num1, num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            continue;
                        }
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}