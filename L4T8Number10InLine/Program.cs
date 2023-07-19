/// <summary>
/// 10 чисел в строке
/// </summary>

class Program
{
    static void Main()
    {
        int i = 1;
        int j = 0;

        while (i <= 100)
        {
            j = 0;
            while (j < 10 && i <= 100)
            {
                j++;
                Console.Write(i.ToString().PadLeft(5));
                i++;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Введите начальное число: ");
        int beginingNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное число: ");
        int endingNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество чисел в строке: ");
        int quantityNumber = Convert.ToInt32(Console.ReadLine());

        i = beginingNumber;
         j = 0;

        while (i <= endingNumber)
        {
            j = 0;
            while (j < quantityNumber && i <= endingNumber)
            {
                j++;
                Console.Write(i.ToString().PadLeft(5));
                i++;
            }
            Console.WriteLine();
        }
    }
}