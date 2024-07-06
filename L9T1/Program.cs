namespace Lesson3_1
{
    /// <summary>
    /// от 1 до 100
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 1; i <= arr.Length; i++)
            {
                    arr[i - 1] = i;
            }

            foreach (int e in arr)
            {
                Console.WriteLine(e);
            }
        }
    }
}