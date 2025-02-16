namespace LeapYearApp
{
    /// <summary>
    /// This class checks if a given year is a leap year.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to check if a given year is a leap year.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");

            // Check if the input is a valid year
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                Environment.Exit(1);
            }

            // Check if the year is a leap year
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
