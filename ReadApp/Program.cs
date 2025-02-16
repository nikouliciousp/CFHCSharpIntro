namespace ReadApp
{
    /// <summary>
    /// This is a simple console application that reads a number from the console.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            // Read a string from the console.
            // If the string can be converted to an integer, print the number.
            string? str = Console.ReadLine();

            if (int.TryParse(str, out int number))
            {
                Console.WriteLine($"You entered a number: {number}");
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }


        }
    }
}
