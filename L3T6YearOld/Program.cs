//Задача Возраст

class Program
{
    static void Main(string[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 20 && year > 10 || year > 110)
        {
            Console.WriteLine("Вам " + year + " лет");
        }
        else if (year % 5 == 0)
        {
            Console.WriteLine("Вам " + year + " лет");
        }
        else if (year % 10 <= 4)
        {
            Console.WriteLine("Вам " + year + " года");
        }
        else
        {
            Console.WriteLine("Вам " + year + " лет");
        }
    }
}

