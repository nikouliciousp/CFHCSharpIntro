namespace FactorReacursiveApp
{
    /// <summary>
    /// This class calculates the factorial of a given number using recursion.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to calculate the factorial of a given number.
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
            Console.WriteLine("Factorial of " + number + " is " + Factorial(number));
        }

        /// <summary>
        /// This method calculates the factorial of a given number using recursion.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
