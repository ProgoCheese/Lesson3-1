//Задача Max/Min
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 1 число: ");
        int firsthNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        if (firsthNum > secondNum)
        {
            Console.WriteLine(firsthNum + " больше чем " + secondNum);
        }
        else if(firsthNum = secondNum)
        {
            Console.WriteLine(secondNum + " равно" + firsthNum);
        }
        else
        {
            Console.WriteLine(secondNum + " больше чем " + firsthNum);
        }
    }
}

