/// <summary>
/// Задача на дом «Print and read»
/// </summary>
class Program
{
    static void Main()
    {
        int a = PrintAndRead("Введите число:");
        int b = PrintAndRead("Введите число ещё раз:");
        int c = PrintAndRead("Введите число последний раз:");
    }

    public static int PrintAndRead(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }
}