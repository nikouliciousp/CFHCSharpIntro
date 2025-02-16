namespace AmstrongApp
{
    /// <summary>
    /// This class checks if a given number is an Armstrong number.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to check if a given number is an Armstrong number.
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

            int originalNumber, remainder, result = 0, n = 0;
            originalNumber = number;

            // Count the number of digits in the number
            for (; originalNumber != 0; originalNumber /= 10, ++n) ;
            { 
                originalNumber = number; 
            }

            // Check if the number is an Armstrong number
            for (; originalNumber != 0; originalNumber /= 10)
            {
                remainder = originalNumber % 10;
                result += (int)Math.Pow(remainder, n);
            }

            if (result == number)
            {
                Console.WriteLine(number + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number.");
            }
        }
    }
}
