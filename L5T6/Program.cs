/// <summary>
/// Простые числа
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Простые числа:");

        for (int i = 2; i <= n; i++)
        {
            bool isSimpleNumder = true;

            for(int j = 2; j < i; j++)
            {
                double x =(double) i % j;
                if (x == 0)
                {
                    isSimpleNumder = false;
                    break;
                }
            }

            if (isSimpleNumder)
            {
                Console.WriteLine(i);
            }
        }
    }

}