namespace Lesson3_1
{
    /// <summary>
    /// Range
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите последнее число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Range userRange = new Range(firstNumber, secondNumber);

            Console.WriteLine($"Длина: {userRange.GetLength}");

            Console.WriteLine("Введите число: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            bool isInside = userRange.IsInside(userNumber);
            Console.WriteLine($"Число находится в последовательности? {isInside}");
        }
    }
}