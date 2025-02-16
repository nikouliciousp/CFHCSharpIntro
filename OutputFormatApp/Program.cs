namespace OutputFormatApp
{
    /// <summary>
    /// This program demonstrates various ways to format output in the console.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Example 1: Simple output
            Console.WriteLine("Hello, World!");

            // Example 2: Formatted output
            string name = "Alice";
            int age = 30;
            Console.WriteLine("Name: {0}, Age: {1}", name, age);

            // Example 3: Interpolated string
            double price = 19.99;
            Console.WriteLine($"The price is {price:C}");

            // Example 4: Output with alignment
            Console.WriteLine("{0,-10} {1,5}", "Item", "Price");
            Console.WriteLine("{0,-10} {1,5:C}", "Apple", 0.99);
            Console.WriteLine("{0,-10} {1,5:C}", "Banana", 0.59);
        }
    }
}
