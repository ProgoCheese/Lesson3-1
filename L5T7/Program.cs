/// <summary>
/// Алгоритм евклида
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число");
        int firstNumber = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Введите второе число");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        bool isEnd = false;

        int greatestСommonВivisor = 1;

        while (isEnd != true)
        {
            int remainder = firstNumber % secondNumber;

            if (remainder == 0)
            {
                isEnd = true;
                greatestСommonВivisor = secondNumber;
            }
            else
            {
                firstNumber = secondNumber;
                secondNumber = remainder;
                continue;
            }
        }

        Console.WriteLine("НОД = {0}",greatestСommonВivisor);
    }
}