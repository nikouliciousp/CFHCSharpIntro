namespace CharReadApp
{
    /// <summary>
    /// This program reads a character from the console and displays its ordinal value.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter characters (press Enter to exit):");

            while (true)
            {
                int ordinal = Console.Read();
                char ch = (char)ordinal;

                if (ch == '\n')
                {
                    break;
                }

                Console.WriteLine($"char: {ch} -- ordinal: {ordinal}");
            }
        }
    }
}
