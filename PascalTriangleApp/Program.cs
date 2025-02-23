namespace PascalTriangleApp
{
    /// <summary>
    /// The main class of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int HEIGHT = 20;
            int[][] triangle = GeneratePascalTriangle(HEIGHT);
            PrintPascalTriangle(triangle);
        }

        /// <summary>
        /// Generates a Pascal triangle with the specified height.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        static int[][] GeneratePascalTriangle(int height)
        {
            // Create the triangle.
            int[][] triangle = new int[height][];

            // Generate the triangle.
            for (int i = 0; i < height; i++)
            {
                // Create the row.
                triangle[i] = new int[i + 1];
                // Fill the row.
                triangle[i][0] = 1;
                // Fill the row.
                triangle[i][i] = 1;

                // Fill the row.
                for (int j = 1; j < i; j++)
                {
                    // Calculate the number.
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            // Return the triangle.
            return triangle;
        }

        /// <summary>
        /// Prints the Pascal triangle.
        /// </summary>
        /// <param name="triangle"></param>
        static void PrintPascalTriangle(int[][] triangle)
        {
            // Calculate the maximum width of the triangle.
            int height = triangle.Length;
            // The maximum width of the triangle is the width of the last row.
            int maxWidth = triangle[height - 1].Length * 2 - 1;

            // Print the triangle.
            for (int i = 0; i < height; i++)
            {
                // Calculate the padding for the current row.
                int padding = (maxWidth - (i * 2 + 1)) / 2;
                // Print the padding.
                Console.Write(new string(' ', padding));

                // Print the numbers of the current row.
                for (int j = 0; j <= i; j++)
                {
                    // Print the number.
                    Console.Write(triangle[i][j] + " ");
                }
                // Move to the next line.
                Console.WriteLine();
            }
        }
    }
}
