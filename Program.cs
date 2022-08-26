using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your name.");
            string Username = Console.ReadLine();
            Console.WriteLine("\n");
            var starttime = DateTime.Now;
            User calcUser = new User() { Username = Username };

            Console.WriteLine("Welcome, " + calcUser.Username + ", to My Calculator!");
            Console.WriteLine("You began using My Calculator at " + starttime);
            Console.WriteLine("\n");

            bool exitLoop = false;

            do
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 to Convert Feet to Meters");
                Console.WriteLine("Press 6 To Exit \n");

                double action = double.Parse(Console.ReadLine());
                double result = 0;
                double input_1 = 0;
                double input_2 = 0;
                var inputstring = "";
                if (action != 6 && action != 5)
                {

                    Console.WriteLine("Enter 1st input");
                    input_1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd input");
                    inputstring = Console.ReadLine();
                    Console.WriteLine(inputstring);
                    input_2 = double.Parse(inputstring);

                }
                switch (action)
                {
                    case 1:
                        {
                            result = Addition(input_1, input_2);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(input_1, input_2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(input_1, input_2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(input_1, input_2);
                            break;
                        }
                    case 5:
                        {
                            double meter, feet;
                            Console.WriteLine("Enter feet :");
                            feet = double.Parse(Console.ReadLine());
                            meter = feet / 3.2808399;
                            Console.WriteLine("\nFeet in meter : " + meter);
                            Console.WriteLine("Press Enter To Continue \n");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            var endtime = DateTime.Now.Subtract(starttime);
                            Console.WriteLine("Thanks for using My Calculator!");
                            Console.WriteLine("You have been using My Calculator for " + endtime);
                            Console.WriteLine("Goodbye, " + calcUser.Username + "!");
                            exitLoop = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;

                }
                if (action != 6 && action != 5)
                {
                    Console.WriteLine("The result is {0} \n", result);
                    ConsoleKeyInfo cki = new ConsoleKeyInfo();
                    do
                    {
                        Console.WriteLine("Press Enter to continue \n");
                        cki = Console.ReadKey();
                    }
                    while (cki.Key != ConsoleKey.Enter);
                    
                }
            } while (!exitLoop);

        } 
        public static double Addition(double input_1, double input_2)
        {
            double result = input_1 + input_2;
            return result;
        } 
        public static double Subtraction(double input_1, double input_2)
        {
            double result = input_1 - input_2;
            return result;
        } 
        public static double Multiplication(double input_1, double input_2)
        {
            double result = input_1 * input_2;
            return result;
        } 
        public static double Division(double input_1, double input_2)
        {
            double result = input_1 / input_2;
            return result;
        }

    }
}