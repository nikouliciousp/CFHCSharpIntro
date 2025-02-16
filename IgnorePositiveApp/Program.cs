namespace IgnorePositiveApp
{
    /// <summary>
    /// This class ignores positive numbers and prints negative numbers.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Please insert different numbers. Insert 0 to finish.");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid number.");
                Environment.Exit(1);
            }

            while (number != 0)
            {
                if (number > 0)
                {
                    Console.WriteLine("Positive numbers are not allowed.");
                }
                else
                {
                    Console.WriteLine($"Number {++count}: {number}");
                }
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid number.");
                    Environment.Exit(1);
                }
            }
        }
    }
}
