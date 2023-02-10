/// <summary>
/// Фибоначи
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество число: ");
        int endingNumber = Convert.ToInt32(Console.ReadLine());

        int deforeTwoNumber = 1;
        int sum = 0;
        int lastNumber = 0;
        int i = 0;

        while(i <= endingNumber)
        {
            i++;
            sum = deforeTwoNumber + lastNumber;
            lastNumber = deforeTwoNumber;
            deforeTwoNumber = sum;
        }

        Console.WriteLine(sum);
    }
}