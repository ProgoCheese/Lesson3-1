class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Число больше 0");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число меньше 0");
        }
        else
        {
            Console.WriteLine("Число равно 0");
        }
    }
}
