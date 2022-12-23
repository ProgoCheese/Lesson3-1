class Program
{
    static void Main()
    {
        Console.Write("Введите команду{print,sum}: ");
        string comand = Console.ReadLine();

        switch (comand)
        {
            case "print":
                Console.WriteLine("Напечатать строчку: ");
                comand = Console.ReadLine();
                Console.WriteLine(comand);
                break;
            case "sum":
                Console.WriteLine("Введите число 1:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число 2:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(firstNumber + secondNumber);
                break;
            default:
                Console.WriteLine("Неверная команда");
                break;
        }
    }
}