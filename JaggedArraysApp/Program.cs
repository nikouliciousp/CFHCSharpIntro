namespace JaggedArraysApp
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
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };
            PrintJaggedArray(jaggedArray);
        }

        /// <summary>
        /// Method to print jagged array.
        /// </summary>
        /// <param name="jaggedArray"></param>
        public static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
