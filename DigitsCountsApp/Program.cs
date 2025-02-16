namespace DigitsCountsApp
{
    /// <summary>
    /// This class counts the number of digits in a given number.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to count the number of digits in a given number.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Environment.Exit(1);
            }

            int count = 0;

            while (number != 0)
            {
                number /= 10;
                count++;
            }

            Console.WriteLine("Number of digits: " + count);
        }
    }
}
