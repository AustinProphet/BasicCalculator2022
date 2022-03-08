namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool backTop = true;

            while (backTop)
            {
                Console.WriteLine("Welcome to My Calculator!");
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 To Exit");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int input_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int input_2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
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
                            Console.WriteLine("Thanks for using My Calculator. Goodbye!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0} \n", result);
                Console.ReadKey();
            }
            backTop = false;
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