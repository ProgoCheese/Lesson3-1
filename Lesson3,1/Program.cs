/// <summary>
/// Задача Вычисление выраж
/// </summary>
class Program
{
    static void Main()
    {
        Console.Write("Введите 1 число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите 2 число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        const double epsilon = 1.0e-10;

        if(Math.Abs(firstNumber - secondNumber) <= epsilon)
        {
            Console.WriteLine("Числа равны" );
        }
        else
        {
            Console.WriteLine("Числа неравны");
        }
    }
}