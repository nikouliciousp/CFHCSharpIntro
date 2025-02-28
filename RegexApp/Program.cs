using System.Text.RegularExpressions;

namespace RegexApp
{
    /// <summary>
    /// Calculator program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string? input;
            string[] tokens = null!;
            int num1, num2;
            string op;
            int result = 0;

            Console.WriteLine("Enter a string to validate:");
            input = Console.ReadLine();

            if (input != null)
            {
                // Split the input string into tokens.
                tokens = Regex.Split(input, @"\s+");
            }

            // Check if the input string is valid.
            num1 = int.Parse(tokens[0]);
            // Check if the operator is valid.
            num2 = int.Parse(tokens[2]);
            // Check if the operator is valid.
            op = tokens[1];

            // Perform the calculation.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
