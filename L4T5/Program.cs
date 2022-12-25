class Program
{
    static void Main()
    {
        int sum = 0;
        int i = 1;
        int endNumber = 2;
        int numberCount = 0;

        while (i <= endNumber)
        {
            sum += i;
            numberCount++;

            ++i;
        }

        float midNummber = (float)sum / numberCount;

        Console.Write(midNummber + " ");

        sum = 0;
        i = 3;
        numberCount = 0;

        while (i <= endNumber)
        {
            if (i % 2 == 0)
            {
                sum += i;
                numberCount++;
            }

            ++i;
        }

        midNummber = (float)sum / numberCount;

        Console.Write(midNummber);
    }
}