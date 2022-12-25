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
            Console.WriteLine("наименьшее " + firsthNum);
            Console.WriteLine("наименьшее " + secondNum);
        }
        else if(firsthNum == secondNum)
        {
            Console.WriteLine(secondNum + " равно" + firsthNum);
        }
        else
        {
            Console.WriteLine("наименьшее " + secondNum);
            Console.WriteLine("наименьшее " + firsthNum);
        }
        int max = (firsthNum > secondNum) ? firsthNum : secondNum;
        int min = (firsthNum < secondNum) ? firsthNum : secondNum;

        Console.WriteLine("Решение при помощи тернарного оператора");
        Console.WriteLine("наименьшее " + max);
        Console.WriteLine("наименьшее " + min);
    }
}

