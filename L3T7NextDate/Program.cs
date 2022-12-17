/// <summary>
/// Задача Следующая дата
/// </summary>
class Program
{
    private static bool isDo = true;

    static void Main()
    {
        while (isDo)
        {
            CheckDatunm();
            Console.WriteLine();
        }
    }

    static void CheckDatunm()
    {
        Console.WriteLine("Введите день:");
        string daytext = Console.ReadLine();

        if (daytext == "n")
        {
            isDo = false;
            return;
        }

        int day = Convert.ToInt32(daytext);

        Console.WriteLine("Введите месяц:");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());

        if (day > 0 && month > 0 && month <= 12 && day <= 31 && year >= 0)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
            {
                day++;
                if (day == 32)
                {
                    day = 1;
                    month++;
                }
            }
            else if (month == 12)
            {
                day++;
                if (day == 32)
                {
                    day = 1;
                    month = 1;
                    year++;
                }
            }
            else if (month == 2)
            {
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    if (day > 29)
                    {
                        Console.WriteLine("Неверная дата");
                        return;
                    }
                    else
                    {
                        day++;
                        if (day == 30)
                        {
                            day = 1;
                            month = 3;
                        }
                    }
                }
                else
                {
                    if (day > 28)
                    {
                        Console.WriteLine("Неверная дата");
                        return;
                    }
                    else
                    {
                        day++;
                        if (day == 29)
                        {
                            day = 1;
                            month = 1;
                        }
                    }
                }
                
            }
            else
            {
                day++;
                if (day == 31)
                {
                    day = 1;
                    month++;
                }
            }
            Console.WriteLine(day + "." + month + "." + year);
        }
        else
        {
            Console.WriteLine("Неверная дата");
        }

        Console.WriteLine();
    }
}