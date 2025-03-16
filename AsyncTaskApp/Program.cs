namespace AsyncTaskApp
{
    /// <summary>
    /// This program demonstrates how to read a file asynchronously.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ReadDisplayFile().Wait();
        }

        /// <summary>
        /// Reads the content of a file and displays it.
        /// </summary>
        /// <returns></returns>
        public static async Task ReadDisplayFile()
        {
            // The path of the file to read.
            string filePath = @"C:\Users\Public\Documents\sample.txt";

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                char[] buffer;

                // Read the file asynchronously.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the content of the file.
                    buffer = new char[(int)reader.BaseStream.Length];
                    // Read the content of the file asynchronously.
                    await reader.ReadAsync(buffer, 0, buffer.Length);
                }

                Console.WriteLine(new string(buffer));
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
