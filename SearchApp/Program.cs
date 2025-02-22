namespace SearchApp
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create an array of integers
            int[] arr = { 5, 5, 2, 1, 9};
            // Print the array
            Console.WriteLine("The array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            const string line = "----------------------------------";
            Console.WriteLine(line);

            // Get the position of the minimum value in the array
            int position = GetPositionOfMinValue(arr);
            // Get the minimum value in the array
            int minValue = GetMinValue(arr);
            // Print the position of the minimum value
            Console.WriteLine($"The position of the minimum value is: {position}");
            // Print the minimum value
            Console.WriteLine($"The minimum value is: {minValue}");
            Console.WriteLine(line);

            // Get the position of the maximum value in the array
            int positionMax = GetPositionOfMaxValue(arr);
            // Get the maximum value in the array
            int maxValue = GetMaxValue(arr);
            // Print the position of the maximum value
            Console.WriteLine($"The position of the maximum value is: {positionMax}");
            // Print the maximum value
            Console.WriteLine($"The maximum value is: {maxValue}");
            Console.WriteLine(line);

            // Sort the array
            int[] sortedArray = SorterArray(arr);
            // Print the sorted array
            Console.WriteLine("The sorted array is: ");
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

        }

        /// <summary>
        /// Get the position of the minimum value in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int GetPositionOfMinValue(int[] arr)
        {
            int min = arr[0];
            int position = 0;

            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty");
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    position = i;
                }
            }
            return position;
        }

        /// <summary>
        /// Get the minimum value in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int GetMinValue(int[] arr)
        {
            int min = arr[0];

            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty");
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Get the maximum value in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetMaxValue(int[] arr)
        {
            int max = arr[0];
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty");
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Get the position of the maximum value in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetPositionOfMaxValue(int[] arr)
        {
            int max = arr[0];
            int position = 0;
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty");
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    position = i;
                }
            }
            return position;
        }

        /// <summary>
        /// Sort an array of integers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int[] SorterArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is null or empty");
            }
            Array.Sort(arr);
            return arr;
        }
    }
}
