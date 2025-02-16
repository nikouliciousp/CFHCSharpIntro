namespace StdInputOutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Please enter your name:");

            // Read input from the user
            string? name = Console.ReadLine();

            // Output a greeting message
            if (name != null)
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else
            {
                Console.WriteLine("Hello, guest!");
            }

            // Prompt the user for a number
            Console.WriteLine("Please enter a number:");

            // Read and parse the number
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Output the number squared
                Console.WriteLine($"The square of {number} is {number * number}.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("That is not a valid number.");
            }
        }
    }
}
