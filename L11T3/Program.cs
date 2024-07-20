namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static void SortArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            int[] array = { 2, 5, 8, 1, 32, 975, 23, 0, 42, 66 };

            SortArray(array);

            Console.WriteLine();

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}