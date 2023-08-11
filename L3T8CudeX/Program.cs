/// <summary>
/// Квадратное уравнение
/// </summary>

/*
называй переменные без сокращений и используя правильный английский язык, а не транслит
переменную х нужно вводить там, где она используется, в данном случае она введена слишком рано
d- это дискриминант, нужно его так и называть
расставить пустые строки для лучшей читаемости текста. например, вот это логический блок, после него можно пустую строку поставить 
Console.Write("Введите коэффициент a:");
double KofA = Convert.ToInt32(Console.ReadLine());
 
убрать лишние пустые строки
сделать документирующий комментарий (///)
 */
class Program
{
    static void Main()
    {
        Console.WriteLine("Программа находит корни квадратного уравнения типа ах^2 + bх + c = 0 ");

        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToInt32(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        double epsilon = 1.0e-10;

        if (a == 0)
        {
            double x = -1 * c / b;
            Console.WriteLine("Корень равен {0}", x);
        }
        else if (b == 0 && c == 0)
        {
            Console.WriteLine("Корень равен 0");
        }
        else if (b == 0)
        {
            if (-1 * c / a > 0)
            {
                double x = Math.Sqrt((-1 * c / a));
                Console.WriteLine("Первый корень равен {0}, второй корень равен {1}", x, -1 * x);
            }
            else
            {
                Console.WriteLine("Нет корня");
            }
        }
        else if (c == 0)
        {
            double x = -1 * b / a;
            Console.WriteLine("Первый корень равен 0, второй корень равено {0}", x);
        }
        else if (discriminant > epsilon)
        {
            double x = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("Первый корень равен {0} Второй корень равен {1}", x, x2);
        }
        else if (discriminant <= epsilon && -1 * discriminant >= -1 * epsilon)
        {
            double x = -(b / 2 * a);
            Console.WriteLine("Корень равен {0}", x);
        }
        else if (discriminant < -1 * epsilon)
        {
            Console.WriteLine("Нет корня");
        }


    }
}