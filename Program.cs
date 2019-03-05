using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Calculator";
            
            

            Console.WriteLine("This is a simple calculator coded in c# ~ brian");
            
            show();

        }

        void show() {

            char operand;
            double v1, v2, result;

            Console.WriteLine("First number:");
            Double.TryParse(Console.ReadLine(), out v1);

            Console.WriteLine("Second number:");
            Double.TryParse(Console.ReadLine(), out v2);

            Console.WriteLine("Enter an operand: (+, -, *, /, ^)");
            Char.TryParse(Console.ReadLine(), out operand);

            switch (operand)
            {
                case '+':
                    result = v1 + v2;
                    Console.WriteLine("Answer: " + result);
                    break;

                case '-':
                    result = v1 - v2;
                    Console.WriteLine("Answer: " + result);
                    break;

                case '*':
                    result = v1 * v2;
                    Console.WriteLine("Answer: " + result);
                    break;

                case '/':
                    result = v1 / v2;
                    Console.WriteLine("Answer: " + result);
                    break;

                case '^':
                    result = Math.Pow(v1, v2);
                    Console.WriteLine("Answer: " + result);
                    break;
            }
            Console.WriteLine("Would you like to calculate another problem? (Y | N)");

            Console.ReadLine().Contains("Y") ? show() : Environment.Exit(0);

        }
    }
}
