using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Calculator";
            
            char opperand;
            double v1, v2, result;

            Console.WriteLine("This is a simple calculator coded in c# ~ brian");

        calc:
            Console.WriteLine("First number:");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number:");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an operrand: (+, -, *, /, ^)");
            opperand = Convert.ToChar(Console.ReadLine());

            switch (opperand)
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

            string again;
            Console.WriteLine("Would you like to calculate another problem? (Y | N)");
            again = Console.ReadLine();
            
            if(again.Contains("Y".ToLower()))
            {
                goto calc;
            } else {
                Environment.Exit(0);
            }
        }
    }
}
