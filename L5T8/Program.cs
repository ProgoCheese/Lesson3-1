/// <summary>
/// Таблица умножения
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i <= number; i++)
        {
            Console.Write(i.ToString().PadRight(3, ' '));

            Console.Write("|");
        }

        Console.WriteLine();

        for(int i = 1; i <= number; i++)
        {
            Console.Write(i.ToString().PadRight(3, ' '));

            Console.Write("|");

            for (int j = 1; j <= number; j++)
            {
                int x = j * i;

                Console.Write(x.ToString().PadRight(3,' '));

                Console.Write("|");
            }
            Console.WriteLine();
        }
    }
}