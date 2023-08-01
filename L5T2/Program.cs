/// <summary>
/// Распечатать числа, кратные четверке от 1 до 100,причем в обратном порядке (то есть, начиная с 100). Использовать цикл for
///Распечатать квадраты чисел от 1 до n при помощи цикла for, где n – задается в коде
///Решить задачу про среднее арифметическое чисел от x до y при помощи цикла for
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("Распечатать числа, кратные четверке от 1 до 100, причем в обратном порядке(то есть, начиная с 100).Использовать цикл for");

        for (int i = 100; i >= 4; i -= 4)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Распечатать квадраты чисел от 1 до n при помощи цикла for. Введите n");
        double n = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i * i);
        }

        Console.WriteLine("Введите х");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y");
        int y = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int j = 0;

        for (int i = x; i <= y; i++)
        {       
            sum += i;    
            j++;
        }

        n = (double)sum / (double)j;

        Console.WriteLine(n);
    }
}