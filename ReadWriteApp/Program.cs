namespace ReadWriteApp
{
    /// <summary>
    /// Main entry point of the application
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // Create a FileStream object for reading and writing
                using FileStream fws = new(@"C:\temp\test-out.txt", FileMode.Append);
                using FileStream frs = new(@"C:\temp\test-read.txt", FileMode.Open);

                // Create a StreamReader and StreamWriter object
                using StreamReader sr = new(frs);
                using StreamWriter sw = new(fws);

                // Read the file
                string? line;

                // Read the file
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }

                Console.WriteLine("File copied successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
