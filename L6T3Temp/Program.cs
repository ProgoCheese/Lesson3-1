/// <summary>
/// Задача на дом «Перевод температур»
/// </summary>
class Program
{
    static void Main()
    {
        double temperature = PrintAndRead("Введите температуру в Цельсиях:");
        CelsiusToKelvin(temperature);
        CelsiusToFahrenheit(temperature);
    }

    private static void CelsiusToKelvin(double celsius)
    {
        Console.WriteLine(celsius + 273.15);
    }

    private static void CelsiusToFahrenheit(double celsius)
    {
        Console.WriteLine(celsius * 9 / 5 + 32);
    }

    public static double PrintAndRead(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }
}