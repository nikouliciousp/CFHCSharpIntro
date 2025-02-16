namespace SwitchApp
{
    /// <summary>
    /// This program demonstrates the use of the switch statement.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3:");

            string? input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You entered One.");
                        break;
                    case 2:
                        Console.WriteLine("You entered Two.");
                        break;
                    case 3:
                        Console.WriteLine("You entered Three.");
                        break;
                    default:
                        Console.WriteLine("Invalid number. Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}