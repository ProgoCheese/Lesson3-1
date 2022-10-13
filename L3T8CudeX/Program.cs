
class Program
{
     static void Main()
    {
        double a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToInt32(Console.ReadLine());
        double c = Convert.ToInt32(Console.ReadLine());
        double x = 1;
        double d = b * b - 4 * a * c;

        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("Нет корня");
        }
        else if (d > 0)
        {
            x = -b + Math.Sqrt(d) / 2 * a;
            double x2 = -b - Math.Sqrt(d) / 2 * a;
            Console.WriteLine("Первый корень равен " + x + ". Второй корень равен " + x2);
        }
        else if (d == 0)
        {
            x = -(b / 2 * a);
            Console.WriteLine("Корень равен " + x);
        }
        else if (d < 0)
        {
            Console.WriteLine("Нет корня");
        }
    }
}