class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальное число: ");
        int beginingNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное число: ");
        int endingNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество чисел в строке: ");
        int quantityNumber = Convert.ToInt32(Console.ReadLine());

        int i = beginingNumber;
        int j = 0;

        while (i <= endingNumber)
        {
            j = 0;
            while (j < quantityNumber)
            {
                j++;
                Console.Write(i.ToString().PadLeft(5));
                i++;
            }
            Console.WriteLine();
        }
    }
}