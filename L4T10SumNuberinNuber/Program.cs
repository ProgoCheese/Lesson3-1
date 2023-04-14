class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        double beginingNumber = Convert.ToDouble(Console.Read());

        double i = 1;
        double j = 15;
        double sum = 0;
        double sumEver = 0;
        double lastNumber = 0;
        double maxNumber = 0;

        while (i <= j)
        {
            
            lastNumber = (int)(beginingNumber % (int)Math.Pow(10, 10-i)) / (int)Math.Pow(10, i - 1);
            if (lastNumber % 2 == 0)
            {
                sumEver += lastNumber;
            }
            sum += lastNumber;
            if (maxNumber < lastNumber)
            {
                maxNumber = lastNumber;
            }
            Console.WriteLine(sum + " " + lastNumber);
            lastNumber = 0;
            i++;
        }

        Console.WriteLine("Сумма " + sum);
        Console.WriteLine("Сумма чет " +  sumEver);
        Console.WriteLine("Макс " + maxNumber);
    }
}