class Program
{
    static void Main()
    {
        int sum = 0;
        int i = 3;
        int endNumber = 21;
        int numberCount = 0;

        while (i <= endNumber)
        {
            if (i % 2 == 0)
            {
                sum += i;
                numberCount++;
            }

            ++i;
        }

        Console.WriteLine(sum + " " + numberCount);
    }
}