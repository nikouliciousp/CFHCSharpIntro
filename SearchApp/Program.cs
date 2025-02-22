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
            // Get the position of the minimum value in the array
            int position = GetPositionOfMinValue(arr);
            // Get the minimum value in the array
            int minValue = GetMinValue(arr);
            // Print the position of the minimum value
            Console.WriteLine($"The position of the minimum value is: {position}");
            // Print the minimum value
            Console.WriteLine($"The minimum value is: {minValue}");

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
    }
}
