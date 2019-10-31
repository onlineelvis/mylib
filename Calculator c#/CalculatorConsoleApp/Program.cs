using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter number 1: ");
            var number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter number 2: ");
            var number2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter operation (+,-,*,/): ");
            var action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("invalid action");
                    break;


            }

        }
    }
}
