/// <summary>
/// Заказ
/// </summary>
class Program
{
    static void Main()
    {
        int priceFirst = PrintAndRead("Введите стоймость 1 блюда:");
        int priceSecondt = PrintAndRead("Введите стоймость 2 блюда:");

        int quantityFirst = PrintAndRead("Введите количество 1 блюда:");
        int quantitySecond = PrintAndRead("Введите количество 2 блюда:");

        double priceAll = priceFirst * quantityFirst + priceSecondt * quantitySecond;

        double discount = 1;

        if(quantityFirst + quantitySecond >= 10 && priceAll >= 1000)
        {
            discount = 0.9;
        }
        else if(priceAll >= 1000)
        {
            discount = 0.95;
        }
        else if(quantityFirst + quantitySecond >= 10)
        {
            discount = 0.95;
        }

        priceAll = priceAll * discount;

        Console.WriteLine("Стоймость заказа составила {0}",priceAll);
    }

    public static int PrintAndRead(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }
}