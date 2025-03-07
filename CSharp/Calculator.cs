namespace CSharp_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Sum");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Square root");
                Console.WriteLine("6. Exponentiation");
                Console.WriteLine("7. Exit program");
                Console.Write("Choose an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                    case 1: // Sum
                        Console.WriteLine("Insert the first number: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the second number: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the sum is: {Sum(a, b):F2}");
                        break;
                    case 2: // Subtraction
                        Console.WriteLine("Insert the first number: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the second number: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the subtraction is: {Subtraction(a, b):F2}");
                        break;
                    case 3: // Multiplication
                        Console.WriteLine("Insert the first number: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the second number: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the multiplication is: {Multiplication(a, b):F2}");
                        break;
                    case 4: // Division
                        Console.WriteLine("Insert the first number: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the second number: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the division is: {Division(a, b):F2}");
                        break;
                    case 5: // Square root
                        Console.WriteLine("Insert the number to perform the radicalization: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the square root is: {SquareRoot(a):F2}");
                        break;
                    case 6: // Exponentiation
                        Console.WriteLine("Insert the base number: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert the exponent: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The result of the exponentiation is: {Exponentiation(a, b):F2}");
                        break;
                    case 7: // Exit program
                        Console.WriteLine("Exiting program...");
                        break;
                }
                Console.WriteLine();
            } while (option != 7);
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }

        private static double Subtraction(double a, double b)
        {
            return a - b;
        }

        private static double Multiplication(double a, double b)
        {
            return a * b;
        }

        private static double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }

        private static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        private static double Exponentiation(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
