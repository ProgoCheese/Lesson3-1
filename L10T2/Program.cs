namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int GetTheGreatestCommonDivis(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GetTheGreatestCommonDivis(b, a % b);
            }
        }

        static void Main()
        {
            Console.WriteLine("Найдем НОД двух целых чисел");

            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("НОД({0}, {1}) равен {2}", firstNumber, secondNumber, GetTheGreatestCommonDivis(firstNumber, secondNumber));
        }
    }
}