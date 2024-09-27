using System;

namespace ConsoleCalculator
{
    class Program
    {
        static int Main(string[] args)
        { 
            double num1, num2 = 0;
            char operation = '\0';
            while(true){
                
                Console.WriteLine("\n Console Calculator\n");

                try
                {
                    Console.Write("Enter an operator (+, -, *, /, R): ");
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid operator");

                }

                if (operation == 'R')
                {
                    // Input first number
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                }
                else if (operation == 'e')
                {
                    return 0;
                }
                else
                {
                    // Input first number
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    // Input second number
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                
                // Perform calculation based on operation
                double result = 0;
                bool isValidOperation = true;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case 'R':
                        result = Math.Sqrt(num1);
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            isValidOperation = false;
                        }

                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        isValidOperation = false;
                        break;
                }

                // Output result if the operation was valid
                if (isValidOperation)
                {
                    if (operation == 'R')
                    {
                        Console.WriteLine($"\nResult: {num1} {operation}  = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}");
                    }

                }

                Console.WriteLine("\nDo you want to continue? (y/n)");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
                Console.ReadKey();
            }
            return 0;
        }
    }
}