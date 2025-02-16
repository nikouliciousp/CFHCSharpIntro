namespace CaptureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Capture user input
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else
            {
                Console.WriteLine("No name entered.");
            }

            // Example 2: Capture current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current date and time: {now}");

            // Example 3: Capture command line arguments
            if (args.Length > 0)
            {
                Console.WriteLine("Command line arguments:");
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            else
            {
                Console.WriteLine("No command line arguments provided.");
            }
        }
    }
}
