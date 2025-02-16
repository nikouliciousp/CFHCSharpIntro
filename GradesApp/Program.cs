namespace GradesApp
{
    /// <summary>
    /// A program that calculates the average of grades entered by the user
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int gradesSum = 0;
            int gradesCount = 0;
            string? input;

            Console.WriteLine("Enter your grades, type 'done' when you're finished");

            while (true)
            {
                input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Input cannot be null");
                    continue;
                }

                if (input.ToLower() == "done")
                {
                    break;
                }

                if (int.TryParse(input, out int grade))
                {
                    gradesSum += grade;
                    gradesCount++;
                }
                else
                {
                    Console.WriteLine("Invalid grade");
                }
            }

            if (gradesCount == 0)
            {
                Console.WriteLine("You didn't enter any grades");
            }
            else
            {
                int gradesAverage = gradesSum / gradesCount;
                Console.WriteLine($"Your average grade is {gradesAverage}");

                if (gradesAverage < 50)
                {
                    Console.WriteLine("You failed");
                }
                else
                {
                    Console.WriteLine("You passed");
                }
        }
    }
}
