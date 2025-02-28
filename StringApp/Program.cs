namespace StringApp
{
    /// <summary>
    /// The main class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string s1;
            string s2 = "Hello World";
            string s3 = "!";
            s1 = s2 + s3;
            string s4 = new string('A', 3);
            string s5 = new string(new char[] { 'A', 'B', 'C' });
            string s6 = new string("Hello Aggain!");
            

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
            System.Console.WriteLine(s3);
            System.Console.WriteLine(s4);
            System.Console.WriteLine(s5);
            System.Console.WriteLine(s6);

        }
    }
}
