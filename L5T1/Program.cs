/// <summary>
/// Задача распечатать числа от 0 до 100 при помощи цикла
/// Распечатать числа от 7 до 121 при помощи цикла
/// Распечатать числа от 100 до 30 при помощи цикла
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("распечатать числа от 0 до 100 при помощи цикла");

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Распечатать числа от 7 до 121 при помощи цикла");

        for (int i = 7; i <= 121; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Распечатать числа от 100 до 30 при помощи цикла");

        for (int i = 100; i >= 30; i--)
        {
            Console.WriteLine(i);
        }
    }
}