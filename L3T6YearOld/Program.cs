/// <summary>
/// Задача возрост
/// </summary>
class Program
{
    private static bool isDo = true;

    static void Main()
    {
        while (isDo)
        {
            CheckDate();
        }
    }

    static void CheckDate()
    {
        Console.Write("Введите возраст: ");

        string yearString = Console.ReadLine();
        if (yearString == "n")
        {
            isDo = false;
            return;
        }

        int year = Convert.ToInt32(yearString);

        if (year < 20 && year > 10 || year > 110)
        {
            Console.WriteLine("Вам " + year + " лет");
        }
        else if (year % 5 == 0)
        {
            Console.WriteLine("Вам " + year + " лет");
        }
        else if (year % 10 <= 4 && year != 1)
        {
            Console.WriteLine("Вам " + year + " года");
        }
        else if (year == 1)
        {
            Console.WriteLine("Вам " + year + " год");
        }
        else
        {
            Console.WriteLine("Вам " + year + " лет");
        }

        Console.WriteLine();
    }
}
