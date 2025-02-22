namespace SymetricArrayApp
{
    /// <summary>
    /// Main class of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            bool isSymetric = IsSymetricArray(array);
            Console.WriteLine(isSymetric);

            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            bool isSymetric2 = IsSymetricArray(array2);
            Console.WriteLine(isSymetric2);
        }

        /// <summary>
        /// Method to check if an array is symetric.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsSymetricArray(int[] array)
        {
            if (array == null)
            {
                return false;
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
