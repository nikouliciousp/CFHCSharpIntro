namespace WriteLineApp
{
    /// <summary>
    /// This class contains the entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Write a simple string
            Console.WriteLine("Hello, World!");

            // Write a formatted string
            string name = "Alice";
            int age = 30;

            Console.WriteLine("Name: {0}, Age: {1}", name, age);

            // Write a string with interpolation
            Console.WriteLine($"Name: {name}, Age: {age}");

            // Write multiple lines
            Console.WriteLine("Line 1\nLine 2\nLine 3");

            // Write a string with special characters
            Console.WriteLine("Tab\tSeparated\tValues");

            // Write a string with escape sequences
            Console.WriteLine("This is a \"quoted\" word");

            // Write a string with a verbatim literal
            Console.WriteLine(@"C:\Users\Alice\Documents");

            // Write an empty line
            Console.WriteLine();
        }
    }
}
