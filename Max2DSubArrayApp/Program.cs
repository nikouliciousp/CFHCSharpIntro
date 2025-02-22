namespace Max2DSubArrayApp
{
    /// <summary>
    /// Program class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2, -1, -4, -20 }, { -8, -3, 4, 2, 1 }, { 3, 8, 10, 1, 3 }, { -4, -1, 1, 7, -6 } };
            Print2DArray(arr);

            int maxSum = Max2DSubArray(arr);
            Console.WriteLine(maxSum);
        }

        /// <summary>
        /// Find maximum sum of 2D subarray
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Max2DSubArray(int[,] arr)
        {
            int maxSum = int.MinValue;
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int[] temp = new int[cols];
                for (int j = i; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        temp[k] += arr[j, k];
                    }
                    int sum = Kadane(temp);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        /// <summary>
        /// Kadane's algorithm
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Kadane(int[] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            return maxSum;
        }

        /// <summary>
        /// Print 2D array
        /// </summary>
        /// <param name="arr"></param>
        public static void Print2DArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
