/// <summary>
/// От 1 до 100 но завершить если >= 30
/// </summary>

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i > 30)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}
