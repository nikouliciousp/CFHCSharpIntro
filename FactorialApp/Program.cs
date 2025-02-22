namespace FactorialApp
{
    /// <summary>
    /// FactorialApp Program class.
    /// This class is the entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int factorial = 1;

            System.Console.Write("Enter a number: ");

            if (int.TryParse(System.Console.ReadLine(), out int number))
            {
                factorial = CalculateFactorial(number);
                System.Console.WriteLine($"Factorial of {number} is {factorial}");
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        /// <summary>
        /// Calculate factorial of a number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                return 0;
            }
           
            if (number == 0)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}
