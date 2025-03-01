namespace StudentApp
{
    /// <summary>
    /// A simple <c>Student</c> POCO class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create and initialize new Student objects
            Student alice = new Student { Id = 1, FirstName = "Alice", LastName = "Smith" };
            Student bob = new Student { Id = 2, FirstName = "Bob", LastName = "Jones" };
            var charlie = new Student { Id = 3, FirstName = "Charlie", LastName = "Brown" };

            // Print the properties of the Student objects
            Console.WriteLine(alice.ToString());
            Console.WriteLine(bob.ToString());
            Console.WriteLine(charlie.ToString());
        }
    }
}
