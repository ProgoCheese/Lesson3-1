namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int SeekBinaryIndex(int[] array, int firstNimber, int lastNumber, int number)
        {
            if (firstNimber > lastNumber)
            {
                return -1;
            }

            int middle = (lastNumber + firstNimber) / 2;

            if (array[middle] == number)
            {
                return middle;
            }
            else if (array[middle] < number)
            {
                return SeekBinaryIndex(array, middle + 1, lastNumber, number);
            }
            else
            {
                return SeekBinaryIndex(array, firstNimber, middle - 1, number);
            }
        }

        public static int BinarySearchFor(int[] array, int firstNimber, int lastNumber, int userNumber)
        {
            int number = -1;

            while (!(firstNimber > lastNumber))
            {
                int middle = (lastNumber + firstNimber) / 2;

                if (array[middle] == userNumber)
                {
                    number = middle;
                    break;
                }
                else if (array[middle] < userNumber)
                {
                    firstNimber = middle + 1;
                }
                else
                {
                    lastNumber = middle - 1;
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