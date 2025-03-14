using System;

namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator Program");


            Console.WriteLine("Enter number 1:");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pick one of the options below:");
            Console.WriteLine("1. Addition +");
            Console.WriteLine("2. Subtraction -");
            Console.WriteLine("3. Division /");
            Console.WriteLine("4. Multiplication *");
            Console.WriteLine("5. Modulus %");

            int Selection = Convert.ToInt32(Console.ReadLine());
            if (Selection < 1 || Selection > 5)
            {
                Console.WriteLine("Invalid option!");
            }

            //Calculations
            switch (Selection)
            {
                case 1: Console.WriteLine("Result: " + (Num1 + Num2));
                break;

                case 2: Console.WriteLine("Result: " + (Num1 - Num2));
                break;

                case 3: Console.WriteLine("Result: " + (Num1 / Num2));
                break;

                case 4: Console.WriteLine("Result: " + (Num1 * Num2));
                break;

                case 5: Console.WriteLine("Result: " + (Num1 % Num2));
                break;
            }



        }
    }
}