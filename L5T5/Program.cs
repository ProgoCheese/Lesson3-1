/// <summary>
/// Break
/// </summary>

class Program
{
    static void Main()
    {
        string password = "пароль";

        Console.WriteLine("Введите пароль:");

        while (true)
        {
            string? userPassword = Console.ReadLine();

            if (userPassword == password)
            {
                break;
            }
            else
            {
                Console.WriteLine("Неправельно, введите ещё раз:");
            }
        }
    }
}