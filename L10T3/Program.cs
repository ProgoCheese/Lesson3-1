namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int SeekBinaryIndex(int[] array, int bottom, int top, int number)
        {
            if (bottom > top)
            {
                return -1;
            }

            int middle = (top + bottom) / 2;

            if (array[middle] == number)
            {
                return middle;
            }
            else if (array[middle] < number)
            {
                return SeekBinaryIndex(array, middle + 1, top, number);
            }
            else
            {
                return SeekBinaryIndex(array, bottom, middle - 1, number);
            }
        }

        public static int BinarySearchFor(int[] array, int bottom, int top, int userNumber)
        {
            int number = -1;

            while (!(bottom > top))
            {
                int middle = (top + bottom) / 2;

                if (array[middle] == userNumber)
                {
                    number = middle;
                    break;
                }
                else if (array[middle] < userNumber)
                {
                    bottom = middle + 1;
                }
                else
                {
                    top = middle - 1;
                }
            }

            return number;
        }

        static void Main()
        {
            int[] array = { 1, 2, 5, 8, 9, 12, 65, 67, 129 };

            Console.WriteLine("Введите целое число, которое программа будет искать в массиве.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат бинарного поиска: Число {0} в массиве под индексом {1}", number, BinarySearchFor(array, 0, array.Length - 1, number));
        }
    }
}