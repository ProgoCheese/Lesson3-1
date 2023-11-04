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

        double result = GetExpression(x, y);  
        Console.WriteLine($"Результат вычисления 3x + 4y = {result}");

        // Функция для вычисления среднего арифметического
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        result = GetAverageValue(x, y);
        Console.WriteLine($"Среднее арифметическое чисел от {x} до {y}: {result}");

        // Функция для вычисления минимума и максимума
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        result = GetMinNumber(x, y);
        Console.WriteLine($"Минимум из {x} и {y}: {result}");

        result = GetMaxNumber(x, y);
        Console.WriteLine($"Максимум из {x} и {y}: {result}");
    }

    static double GetExpression(double x, double y)
    {
        double result = 3 * x + 4 * y;
        return result;
    }

    static double GetAverageValue(double begin, double end)
    {
        double sum = 0;
        for (double i = begin; i <= end; i++)
        {
            sum += i;
        }
        double average = (double)sum / (end - begin + 1);
        return average;
    }

    static double GetMinNumber(double a, double b)
    {
        double min = a < b ? a : b;
        return min;
    }

    static double GetMaxNumber(double a, double b)
    {
        double max = a > b ? a : b;
        return max;
    }
}