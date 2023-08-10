/// <summary>
/// Вклад
/// </summary>
class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ставку годовых (%):");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        double monthInterestRate = interestRate / 100 / 12;

        double totalAmount = depositAmount;
        double profit = 0;

        for (int i = 0; i < months; i++)
        {
            double monthProfit = totalAmount * monthInterestRate;
            totalAmount += monthProfit;
            profit += monthProfit;
        }

        Console.WriteLine("Сумма вклада с учетом процентов: " + totalAmount);
        Console.WriteLine("Прибыль: " + profit);
    }
}