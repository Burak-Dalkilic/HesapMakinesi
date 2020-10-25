using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1. Number: ");
            double number1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter 2. Number:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("which action would you like to do ?  (+, -, *, /)");
            string action = Console.ReadLine();

            double result;
            // Conditions
            switch (action)
            {
                case "+":
                    result = sum(number1, number2);
                    Console.WriteLine("Result:" + result);
                    break;

                case "-":
                    result = substraction(number1, number2);
                    Console.WriteLine("Result:" + result);
                    break;

                case "*":
                    result = multiplication(number1, number2);
                    Console.WriteLine("Result:" + result);
                    break;

                case "/":
                    result = division(number1, number2);
                    Console.WriteLine("Result:" + result);
                    break;

                default:
                    Console.WriteLine("Wrong Action!! Please Try Again!");
                    break;
            }


            //Methods
            static double sum(double num1, double num2)
            {

                double result = num1 + num2;
                return result;

            }


            static double substraction(double num1, double num2)
            {

                double result = num1 - num2;
                return result;

            }


            static double multiplication(double num1, double num2)
            {

                double result = num1 * num2;
                return result;

            }



            static double division(double num1, double num2)
            {

                double result = num1 / num2;
                return result;

            }



        }


    }

}
