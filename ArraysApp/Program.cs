namespace ArraysApp
{
    /// <summary>
    /// Main class of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare and initialize an array of integers.
            int[] numbers = new int[3];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }

            // Declare and initialize an array of integers.
            int[] ints = { 1, 2, 3, 4, 5 };

            foreach (var number in ints)
            {
                System.Console.WriteLine(number);
            }

            // Declare and initialize an array of strings.
            string[] names = new string[3] { "Jack", "John", "Mary" };

            foreach (var name in names)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}
