namespace SwitchFallThroughApp
{
    /// <summary>
    /// This program demonstrates the use of the switch statement.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3:");

            string? input = Console.ReadLine();

            if (input != null)
            {
                int number = int.Parse(input);

                switch (number)
                {
                    case 1:
                        Console.WriteLine("You entered one.");
                        goto case 2;
                    case 2:
                        Console.WriteLine("You entered two.");
                        goto case 3;
                    case 3:
                        Console.WriteLine("You entered three.");
                        break;
                    default:
                        Console.WriteLine("Invalid number.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }
}
