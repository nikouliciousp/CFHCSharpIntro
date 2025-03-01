namespace ExceptionApp
{
    /// <summary>
    /// Main program class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;

            // Loop until the user enters 'q'.
            while (true)
            {
                // Try to parse the user input.
                try
                {
                    Console.Write("Enter a number or 'q' to quit: ");
                    string? input = Console.ReadLine();

                    // Check if the user wants to quit.
                    if (input == "q")
                    {
                        break;
                    }

                    // Parse the user input.
                    if (input != null)
                    {
                        num = int.Parse(input);
                        Console.WriteLine($"You entered: {num}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large or too small.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
