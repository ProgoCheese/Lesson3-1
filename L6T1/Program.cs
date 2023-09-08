/// <summary>
/// Задачи из 6 лекции
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        double y = Convert.ToDouble(Console.ReadLine());

        CalculateExpression(x, y);  

        // Функция для вычисления среднего арифметического
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        CalculateAverageValue(x, y);

        // Функция для вычисления минимума и максимума
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        CalculateMinNumber(x, y);
        CalculateMaxNumber(x, y);
    }

    static void CalculateExpression(double x, double y)
    {
        double result = 3 * x + 4 * y;
        Console.WriteLine($"Результат вычисления 3x + 4y = {result}");
    }

    static void CalculateAverageValue(double begin, double end)
    {
        double sum = 0;
        for (double i = begin; i <= end; i++)
        {
            sum += i;
        }
        double average = (double)sum / (end - begin + 1);
        Console.WriteLine($"Среднее арифметическое чисел от {begin} до {end}: {average}");
    }

    static void CalculateMinNumber(double a, double b)
    {
        double min = a < b ? a : b;
        Console.WriteLine($"Минимум из {a} и {b}: {min}");
    }

    static void CalculateMaxNumber(double a, double b)
    {
        double max = a > b ? a : b;
        Console.WriteLine($"Максимум из {a} и {b}: {max}");
    }
}