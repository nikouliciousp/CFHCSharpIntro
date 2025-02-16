namespace FiboIterApp
{
    /// <summary>
    /// Fibonacci series using iterator
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci series using iterator");
            Console.WriteLine("Enter the number of terms in the series");

            int n = Convert.ToInt32(Console.ReadLine());

            // Display the series
            foreach (int i in Fibonacci(n))
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Fibonacci series using iterator
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static IEnumerable<int> Fibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
