namespace OptionalParamApp
{
    /// <summary>
    /// Main program class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateTime date = GetDate(2020, 1, 1, 12, 0, 0, 0);
            Console.WriteLine(date);

            date = GetDate(2020, 1, 1);
            Console.WriteLine(date);

            date = GetDate(day:1, hour:3);
            Console.WriteLine(date);
        }

        /// <summary>
        /// Get a date with optional parameters
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="min"></param>
        /// <param name="sec"></param>
        /// <param name="milli"></param>
        /// <returns></returns>
        public static DateTime GetDate(int year = 1970, int month = 1, int day = 1, int hour = 0, int min = 0, int sec = 0, int milli = 0)
        {
            return new DateTime(year, month, day, hour, min, sec, milli, DateTimeKind.Utc);
        }
    }
}
