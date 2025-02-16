using System.Numerics;

namespace BigIntegerApp
{
    /// <summary>
    /// Demonstrates the use of the BigInteger class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Example of using BigInteger
            BigInteger bigNumber1 = BigInteger.Parse("123456789012345678901234567890");
            BigInteger bigNumber2 = BigInteger.Parse("987654321098765432109876543210");

            // Perform some arithmetic operations
            BigInteger sum = bigNumber1 + bigNumber2;
            BigInteger difference = bigNumber1 - bigNumber2;
            BigInteger product = bigNumber1 * bigNumber2;
            BigInteger quotient = bigNumber1 / bigNumber2;

            // Display the results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}
