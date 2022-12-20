/// <summary>
/// Задача Вычисление выраж
/// </summary>
class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double e = 1.0e-10;
        if(Math.Abs(a - b) <= e)
        {
            Console.WriteLine("Числа равны" );
        }
        else
        {
            Console.WriteLine("Числа неравны");
        }
    }
}