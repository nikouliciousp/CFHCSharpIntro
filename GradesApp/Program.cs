namespace GradesApp
{
    internal class Program
    {
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
            }
        }
    }
}
