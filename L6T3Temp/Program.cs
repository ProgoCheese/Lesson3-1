/// <summary>
/// Задача на дом «Перевод температур»
/// </summary>
class Program
{
    static void Main()
    {
        double temperature = PrintAndRead("Введите температуру в Цельсиях:");
        double kelvin = CelsiusToKelvin(temperature);
        double fahrenheit = CelsiusToFahrenheit(temperature);

        Console.WriteLine("Кельвины = {0} , фаренгейты = {1}", kelvin, fahrenheit);
    }

    private static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    private static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    public static double PrintAndRead(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }
}