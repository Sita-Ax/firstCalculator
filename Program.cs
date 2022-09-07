namespace firstCalculator
{
    internal class Program
    {

        public static int Addition(int n1, int n2)
        {
            int result;
            result = n1 + n2;
            return result;
        }
        public static int Subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }

        public static int Division(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2; 
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
            }
                return result;
        }
        public static int Multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }

        static void Menu()
        {
            Console.WriteLine("-----Calculator Menu------");
            Console.WriteLine("Press on 1 to add two numbers");
            Console.WriteLine("Press on 2 to subtract of two numbers");
            Console.WriteLine("Press on 3 to divide two numbers");
            Console.WriteLine("Press on 4 to multiply of two numbers");
            Console.WriteLine("Press on 5 to exit!");
        }

        static int Choose(string v)
        {
            string? input = Question(v);
            int menu = Convert.ToInt32(input);
            return menu;
        }

        static string? Question(string v)
        {
            Console.WriteLine("What is your menu number?");
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int number1, number2;
            bool loop = true;
            ConsoleKeyInfo status;
            while (loop)
            {
                Menu();
                int menuChoice = Choose("Menu!");
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The adding result is: {0} ", Addition(number1, number2));
                        break;
                    case 2:
                        Console.WriteLine("Enter the first number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The subtraction result is: {0} ", Subtraction(number1, number2));
                        break;
                    case 3:
                        Console.WriteLine("Enter the first number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The division result is: {0} ", Division(number1, number2));
                        break;
                    case 4:
                        Console.WriteLine("Enter the first number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The multiply result is: {0} ", Multiplication(number1, number2));
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid value.");
                        break;
                }
                Console.WriteLine("Do you want to quit press (Y) or the menu press some other button. ");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }

        }
    }
}