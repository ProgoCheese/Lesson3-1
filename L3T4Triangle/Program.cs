/// <summary>
/// Треугольник
/// </summary>/// 

class Program
{
    static void Main()
    {
        Console.Write("Введите координату x1: ");
        int firstPointX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату y1: ");
        int firstPointY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату x2: ");
        int secondPointX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату y2: ");
        int secondPointY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату x3: ");
        int thirdPointX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату y3: ");
        int thirdPointY = Convert.ToInt32(Console.ReadLine());

        if(firstPointX == secondPointX && secondPointX == thirdPointX || firstPointY == secondPointY && secondPointY == thirdPointY)
        {
            Console.WriteLine("Площадь не надо вычислять");
        }
        else
        {
            double firstLine = Math.Sqrt((firstPointY - secondPointY)*(firstPointY - secondPointY) + (firstPointX-secondPointX)*(firstPointX - secondPointX));
            double secondLine = Math.Sqrt((secondPointY - thirdPointY)*(secondPointY - thirdPointY) + (secondPointX - thirdPointX)*(secondPointX - thirdPointX));
            double thirdLine = Math.Sqrt((firstPointY - thirdPointY) *(firstPointY - thirdPointY) + (firstPointX- thirdPointX) *(firstPointX - thirdPointX));
         
            double halfPerimeter = (firstLine + secondLine + thirdLine)/2;

            double square = Math.Sqrt(halfPerimeter*(halfPerimeter-firstLine)*(halfPerimeter - secondLine) *(halfPerimeter - thirdLine));
            Console.WriteLine("Площадь треугольника равна {0}", square);
        }
    }
}