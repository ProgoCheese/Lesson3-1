class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальное число: ");
        int beginingNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начальное число: ");
        int endingNumber = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int countNumber = 0;
        int i = beginingNumber;


        while (i <= endingNumber)
        {            
            sum += i;
            countNumber++;
            i++;
        }

        double midNumber = (double)sum / countNumber;

        Console.WriteLine("Средние арифмитическое " + midNumber);

        int countNumberEven = 0;
        i = beginingNumber;
        int sumEven = 0;

        while (i <= endingNumber)
        {

            if (i % 2 == 0)
            {
                sumEven += i;
                countNumberEven++;
            }
            i++;
        }

        double midNumberEver = (double)sumEven / countNumberEven;

        Console.WriteLine("Средние арифмитическое четных " + midNumberEver);
    }
}