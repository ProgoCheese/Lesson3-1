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
        double coefficientA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double coefficientB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double coefficientC = Convert.ToInt32(Console.ReadLine());
        double x;
        double discriminant = Math.Pow(coefficientB,2) - 4 * coefficientA * coefficientC;

        if (coefficientA == 0 && coefficientB == 0 && coefficientC == 0)
        {
            Console.WriteLine("Нет корня");
        }
        else if (discriminant > 0)
        {
            x = -coefficientB + Math.Sqrt(discriminant) / 2 * coefficientA;
            double x2 = -coefficientB - Math.Sqrt(discriminant) / 2 * coefficientA;
            Console.WriteLine("Первый корень равен {0} Второй корень равен {1}",x,x2);
        }
        else if (discriminant == 0)
        {
            x = -(coefficientB / 2 * coefficientA);
            Console.WriteLine("Корень равен {0}",x);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("Нет корня");
        }
    }
}