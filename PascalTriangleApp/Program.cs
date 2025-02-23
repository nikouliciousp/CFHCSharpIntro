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
            int[][] triangle = new int[height][];
            for (int i = 0; i < height; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            return triangle;
        }

        /// <summary>
        /// Prints the Pascal triangle.
        /// </summary>
        /// <param name="triangle"></param>
        static void PrintPascalTriangle(int[][] triangle)
        {
            int height = triangle.Length;
            int maxWidth = triangle[height - 1].Length * 2 - 1;
            for (int i = 0; i < height; i++)
            {
                int padding = (maxWidth - (i * 2 + 1)) / 2;
                Console.Write(new string(' ', padding));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
