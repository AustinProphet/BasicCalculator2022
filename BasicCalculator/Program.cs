namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var starttime = DateTime.Now;
            bool exitLoop = false;

            do
            {
                Console.WriteLine("Welcome to My Calculator!");
                Console.WriteLine("You Began Using My Calculator at " + starttime);
                Console.WriteLine("\n");
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 to Convert Feet to Meters");
                Console.WriteLine("Press 6 To Exit \n");

                int action = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                int input_1 = 0;
                int input_2 = 0;
                if (action != 6 && action != 5)
                {

                    Console.WriteLine("Enter 1st input");
                    input_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd input");
                    input_2 = Convert.ToInt32(Console.ReadLine());

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
                            feet = Convert.ToInt32(Console.ReadLine());
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
                            Console.WriteLine("Goodbye!");
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
                    Console.WriteLine("Press Enter to continue \n");
                    Console.ReadKey();
                }
            } while (!exitLoop);

        } 
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        } 
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        } 
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        } 
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }

    }
}