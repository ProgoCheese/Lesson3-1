/// <summary>
/// Приветствие
/// </summary>/// 

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string userName = Console.ReadLine();

        Console.Write("Привет, {0}!", userName);
    }
}
