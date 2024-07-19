namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int GetTheGreatestCommonDivisor(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GetTheGreatestCommonDivisor(b, a % b);
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите 2 числа");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Их НОД равен " + GetTheGreatestCommonDivisor(firstNumber, secondNumber));
        }
    }
}