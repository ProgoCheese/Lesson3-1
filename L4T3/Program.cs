class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 4: ");
        int comand = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 1:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число 2:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        switch (comand)
        {
            case 1:
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case 2:
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case 3:
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case 4:
                Console.WriteLine(firstNumber / secondNumber);
                break;
            default:
                Console.WriteLine("Неверная команда");
                break;
        }
    }
}