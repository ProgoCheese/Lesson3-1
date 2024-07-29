namespace Lesson3_1
{
    class Program
    {
        public static void PyromidalSort(int[] array, int size)
        {
            for (int i = (size / 2); i >= 0; i--)
            {
                ConversionToHeap(array, i, size - 1);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                ConversionToHeap(array, 0, i - 1);
            }
        }

        public static void ConversionToHeap(int[] array, int root, int left)
        {
            int maxChild;

            bool isDone = false;

            while ((root * 2 <= left) && (!isDone))
            {
                if (root * 2 == left)
                {
                    maxChild = root * 2;
                }
                else if (array[root * 2] > array[root * 2 + 1])
                {
                    maxChild = root * 2;
                }
                else
                {
                    maxChild = (root * 2) + 1;
                }

                if (array[root] < array[maxChild])
                {
                    (array[root], array[maxChild]) = (array[maxChild], array[root]);
                    root = maxChild;
                }
                else
                {
                    isDone = true;
                }
            }
        }

        static void Main()
        {
            int[] array = [2, 5, 8, 1, 32, 975, 23, 0, 42, 66];

            PyromidalSort(array, array.Length);

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}