namespace Lesson3_1
{
    /// <summary>
    /// от 1 до 100
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] array = new int[100];

            for (int i = 1; i <= array.Length; i++)
            {
                array[i - 1] = i;
            }

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}