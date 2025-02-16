namespace NullablesApp
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare a nullable integer
            int num = 5;

            // Declare a nullable integer
            int? i = null;

            // Display the value of nullable integer
            Console.WriteLine(num);

            // Display the value of nullable integer
            Console.WriteLine("i: {0}", (i == null) ? "null" : "not null");

            // Display the value of nullable integer
            Console.WriteLine(i.GetValueOrDefault(10));
        }
    }
}
