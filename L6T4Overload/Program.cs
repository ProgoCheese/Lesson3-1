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

        Console.WriteLine("Размер byte: " + GetTypeSize(b));
        Console.WriteLine("Размер short: " + GetTypeSize(s));
        Console.WriteLine("Размер int: " + GetTypeSize(i));
        Console.WriteLine("Размер long: " + GetTypeSize(l));
        Console.WriteLine("Размер float: " + GetTypeSize(f));
        Console.WriteLine("Размер double: " + GetTypeSize(d));
    }
    static int GetTypeSize(byte value)
    {
        return sizeof(byte);
    }

    static int GetTypeSize(short value)
    {
        return sizeof(short);
    }

    static int GetTypeSize(int value)
    {
        return sizeof(int);
    }

    static int GetTypeSize(long value)
    {
        return sizeof(long);
    }

    static int GetTypeSize(float value)
    {
        return sizeof(float);
    }

    static int GetTypeSize(double value)
    {
        return sizeof(double);
    }
}