namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                }
            }
        }

        static void Main()
        {
            int[] array = [2, 5, 8, 1, 32, 975, 23, 0, 42, 66];

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            SortArray(array);

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}