/// <summary>
/// Задача «Стоимость заказа»
/// </summary>

class Program
{
    static void Main()
    {
        byte b = 1;
        short s = 2;
        int i = 3;
        long l = 4;
        float f = 5.0f;
        double d = 6.0;

        int size = GetTypeSize(b);
        Console.WriteLine(size);

        size = GetTypeSize(s);
        Console.WriteLine(size);

        size = GetTypeSize(i);
        Console.WriteLine(size);

        size = GetTypeSize(l);
        Console.WriteLine(size);

        size = GetTypeSize(f);
        Console.WriteLine(size);

        size = GetTypeSize(d);
        Console.WriteLine(size);
    }

    static int GetTypeSize(byte value)
    {
        return 1;
    }

    static int GetTypeSize(short value)
    {
        return 2;
    }

    static int GetTypeSize(int value)
    {
        return 4;
    }

    static int GetTypeSize(long value)
    {
        return 8;
    }

    static int GetTypeSize(float value)
    {
        return 4;
    }

    static int GetTypeSize(double value)
    {
        return 8;
    }
}