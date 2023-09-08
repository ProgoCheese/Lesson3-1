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

        GetTypeSize(b);
        GetTypeSize(s);
        GetTypeSize(i);
        GetTypeSize(l);
        GetTypeSize(f);
        GetTypeSize(d);
    }

    static void GetTypeSize(byte value)
    {
        Console.WriteLine("Размер byte: 1");
    }

    static void GetTypeSize(short value)
    {
        Console.WriteLine("Размер short: 2");
    }

    static void GetTypeSize(int value)
    {
        Console.WriteLine("Размер int: 4");
    }

    static void GetTypeSize(long value)
    {
        Console.WriteLine("Размер long: 8");
    }

    static void GetTypeSize(float value)
    {
        Console.WriteLine("Размер float: 4");
    }

    static void GetTypeSize(double value)
    {
        Console.WriteLine("Размер double: 8");
    }
}