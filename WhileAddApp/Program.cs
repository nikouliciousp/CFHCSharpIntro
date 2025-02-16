namespace WhileAddApp
{
    /// <summary>
    /// Main class of the program.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Main method of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            int multiplier = 1;

            while (i <= 10)
            {
                sum += i;
                multiplier *= i;
                i++;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Multiplier: {multiplier}");
        }
    }
}
