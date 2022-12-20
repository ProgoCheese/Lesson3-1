class Program
{
    static void Main()
    {
        Console.WriteLine("Введите команду{print,sum}");
        string a = Console.ReadLine();
        switch (a)
        {
            case "print":
                Console.WriteLine("Напечатать строчку: ");
                a = Console.ReadLine();
                Console.WriteLine(a);
                break;
            case "sum":
                Console.WriteLine("Введите число 1:");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(c + b);
                break;
            default:
                Console.WriteLine("Неверная команда");
                break;
        }
    }
}