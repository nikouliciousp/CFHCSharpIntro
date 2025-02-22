namespace ForApp
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] cities = { "New York", "London", "Mumbai", "Chicago" };

            for (int i = 0; i < cities.Length; i++)
            {
                System.Console.WriteLine(cities[i]);
            }

            foreach (string city in cities)
            {
                System.Console.WriteLine(city);
            }
        }
    }
}
