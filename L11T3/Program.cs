namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static void SortArr(int[] a)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                for (int i = 0; i < a.Length - j - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;


                    }
                }
            }
        }

        static void Main()
        {
            int[] a = { 2, 5, 8, 1, 32, 975, 23, 0, 42, 66 };

            SortArr(a);

            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}