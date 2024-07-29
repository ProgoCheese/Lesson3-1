namespace Lesson3_1
{
    /// <summary>
    /// сортировака вставками
    /// </summary>
    class Program
    {
        public static void SortArrayInserts(int[] array)
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

            PrintArray(array);

            SortArrayInserts(array);

            Console.WriteLine("\nОтсортированный массив:");

            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}