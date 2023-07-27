/// <summary>
/// От 0 до 100 с условиями
/// </summary>

class Program
{
    static void Main()
    {
        int i = 0;

        for (i = 0; i <= 100; i++)
        {
            int n = i % 3;

            if (i == 5 || n == 0 || (i >= 60 && i <= 80))
            {
                continue;
            }

            Console.WriteLine(i);
        }

        Console.WriteLine("Теперь с while");

        i = 0;
        while (i <= 100)
        {
            int n = i % 3;

            if (i == 5 || n == 0 || (i >= 60 && i <= 80))
            {
                ++i;
                continue;
            }

            Console.WriteLine(i);

            ++i;
        }
    }
}