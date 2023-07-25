/// <summary>
/// Цифры числа
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());


        double j = 0;
        double n = number;


        while (n != 0)
        {
            n = (int)n / 10;
            j++;
        }

        double sum = 0;
        double sumEver = 0;
        double maxNumber = 0;

        while (j != -1)
        {
            double i = (int)number / (int)Math.Pow(10, j);
            number -= (int)i * Math.Pow(10, j);
            j--;
            sum += (int)i;
            n = i % 2;
            if (n == 1)
            {
                sumEver += i;
            }
            if (maxNumber < i)
            {
                maxNumber = i;
            }
        }

        Console.WriteLine("Сумма " + sum);
        Console.WriteLine("Сумма нечет " + sumEver);
        Console.WriteLine("Макс " + maxNumber);
    }
}