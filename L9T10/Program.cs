namespace Lesson3_1
{
    /// <summary>
    /// сортировка
    /// </summary>
    class Program
    {
        public static bool IsGrowingArray(int[] array)
        {
            bool isGrowingArray = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    isGrowingArray = false;
                }
            }

            return isGrowingArray;
        }

        public static bool IsDescendingArray(int[] array)
        {
            bool isGrowingArray = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    isGrowingArray = false;
                }
            }

            return isGrowingArray;
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 8, 9, 12, 945};

            bool isGrowingArray = IsGrowingArray(array);
            bool isDescendingArray = IsDescendingArray(array);

            Console.WriteLine($"массив возрастает: {isGrowingArray}, он убывает: {isDescendingArray}");
        }
    }
}