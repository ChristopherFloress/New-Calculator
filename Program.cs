using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        var calculator = new Calculator();

        while (true)
        {
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            int result;
            switch (op)
            {
                case "+":
                    result = calculator.Add(num1, num2);
                    break;
                case "-":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "*":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        continue;
                    }
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Unknown operator.");
                    continue;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (y/n): ");
            string? answer = Console.ReadLine();
            if (answer?.Trim().ToLower() != "y")
                break;
        }
    }
}

