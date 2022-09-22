namespace calculations1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Make calculations entring 2 numbers");

            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chose an option from the list below.");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Division");
            Console.Write("Your option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Result of {number1} + {number2} is {number1 + number2}");
                    break;
                case "2":
                    Console.WriteLine($"Result of {number1} - {number2} is {number1 - number2}");
                    break;
                case "3":
                    Console.WriteLine($"Result of {number1} * {number2} is {number1 * number2}");
                    break;
                case "4":
                    Console.WriteLine($"Result of {number1} / {number2} is {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Sorry, bad input :(");
                    break;
            }

        }
    }
}
