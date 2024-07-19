namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int SearchIdBinary(int[] array, int left, int right, int number)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (right + left) / 2;

            if (array[middle] == number)
            {
                return middle;
            }
            else if (array[middle] < number)
            {
                return SearchIdBinary(array, middle + 1, right, number);
            }
            else
            {
                return SearchIdBinary(array, left, middle - 1, number);
            }
        }

        public static int BinarySearchFor(int[] a, int left, int right, int x)
        {
            int b = -1;

            while (!(left > right))
            {
                int middle = (right + left) / 2;

                if (a[middle] == x)
                {
                    b = middle;
                    break;
                }
                else if (a[middle] < x)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return b;
        }

        static void Main()
        {
            int[] a = { 1, 2, 5, 8, 9, 12, 65, 67, 129 };

            Console.WriteLine("Введите число для поиска");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат " + BinarySearchFor(a, 0, a.Length - 1, x));
        }
    }
}