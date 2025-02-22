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
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 5;
            int position = Search(arr, key);
            if (position != -1)
            {
                Console.WriteLine("Element found at index: " + position);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        /// <summary>
        /// Search for a key in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Search(int[] arr, int key)
        {
            int position = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
}
