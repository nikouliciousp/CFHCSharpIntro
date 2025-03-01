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
            // Create a new Student object
            Student alice = new Student();
            Student bob = new();
            var charlie = new Student();

            // Set the properties of the Student object
            alice.Id = 1;
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            Console.WriteLine(alice.ToString());

            // Set the properties of the Student object
            bob.Id = 2;
            bob.FirstName = "Bob";
            bob.LastName = "Jones";
            Console.WriteLine(bob.ToString());

            // Set the properties of the Student object
            charlie.Id = 3;
            charlie.FirstName = "Charlie";
            charlie.LastName = "Brown";
            Console.WriteLine(charlie.ToString());
        }
    }
}
