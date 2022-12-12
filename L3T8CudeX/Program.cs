//Квадратное уравнение

class Program
{
     static void Main()
    {
        Console.WriteLine("Программа находит корни квадратного уравнения типа");
        Console.Write("Введите коэффициент a:");
        double KofA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите коэффициент b:");
        double KofB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите коэффициент c:");
        double KofC = Convert.ToInt32(Console.ReadLine());
        double x;
        double d = KofB * KofB - 4 * KofA * KofC;

        if (KofA == 0 && KofB == 0 && KofC == 0)
        {
            Console.WriteLine("Нет корня");
        }
        else if (d > 0)
        {
            x = -KofB + Math.Sqrt(d) / 2 * KofA;
            double x2 = -KofB - Math.Sqrt(d) / 2 * KofA;
            Console.WriteLine("Первый корень равен {0} Второй корень равен {1}",x,x2);
        }
        else if (d == 0)
        {
            x = -(KofB / 2 * KofA);
            Console.WriteLine("Корень равен {0}",x);
        }
        else if (d < 0)
        {
            Console.WriteLine("Нет корня");
        }
    }
}