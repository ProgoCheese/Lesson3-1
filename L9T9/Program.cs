namespace Lesson3_1
{
    /// <summary>
    /// AM
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 6, 2, 8, 9, 12, 945, 23, 4 };

            int halfLength = 0;

            if (array.Length % 2 == 0)
            {
                halfLength = array.Length / 2;
            }
            else
            {
                halfLength = (array.Length + 1) / 2;
            }

            for (int i = 0; i < halfLength; i++)
            {
                int a = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = a;
            }

            foreach (int e in array)
            {
                Console.Write(e + " ");
            }
        }
    }
}