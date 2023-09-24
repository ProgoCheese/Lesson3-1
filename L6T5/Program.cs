/// <summary>
/// Заказ
/// </summary>
class Program
{
    static void Main()
    {
        double priceFirst = PrintAndRead("Введите стоймость 1 блюда:");
        double priceSecondt = PrintAndRead("Введите стоймость 2 блюда:");

        double quantityFirst = PrintAndRead("Введите количество 1 блюда:");
        double quantitySecond = PrintAndRead("Введите количество 2 блюда:");

        double priceAll = priceFirst * quantityFirst + priceSecondt * quantitySecond;

        double disount = CalculationDiscount(quantityFirst, quantitySecond, priceAll);
        Console.WriteLine(disount*priceAll);
    }

    public static double CalculationDiscount(double quantityFirst, double quantitySecond, double priceAll)
    {
        double discount = 1;

        if (quantityFirst + quantitySecond >= 10 && priceAll >= 1000)
        {
            discount = 0.9;
        }
        else if (priceAll >= 1000)
        {
            discount = 0.95;
        }
        else if (quantityFirst + quantitySecond >= 10)
        {
            discount = 0.95;
        }

        return discount;
    }

    public static int PrintAndRead(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }
}