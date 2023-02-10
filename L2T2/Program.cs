/// <summary>
/// Окружность
/// </summary>/// 

class Program
{
    static void Main()
    {
        Console.Write("Радиус: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        double square = Math.PI * Math.Pow(radius, 2);
        double length = 2 * Math.PI * radius;

        Console.Write("радиус = {2} , площадь = {0:f2} , периметор = {1:f2}" , square , length , radius);
    }
}
