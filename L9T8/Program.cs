namespace Lesson3_1
{
    /// <summary>
    /// AM
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 6, 2, 8, 9, 12, 945, 23 };

            int sum = 0;
            int count = 0;

            foreach (int e in array)
            {
                if (e % 2 == 0)
                {
                    sum += e;
                    count++;
                }
            }

            Console.WriteLine(sum / count);
        }
    }
}