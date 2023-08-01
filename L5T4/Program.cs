/// <summary>
/// От 0 до 100 с условиями
/// </summary>

class Program
{
    static void Main()
    {

        for (int j = 0; j <= 100; j++)
        {
            int n = j% 3;

            if (j == 5 || n == 0 || (j >= 60 && j <= 80))
            {
                continue;
            }

            Console.WriteLine(j);
        }

        Console.WriteLine("Теперь с while");

        int i = 0;
        while ( i <= 100)
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