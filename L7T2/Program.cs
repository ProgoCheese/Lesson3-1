/// <summary>
/// Range
/// </summary>
class Program
{
    public class Range
    {
        public int From { get; set; } 
        public int To { get; set; }

        //На самом деле если мы принимаем 2 вещественных числа то количество будет бесконечно т.к. вещественных бесконечно
        // Так что будем считать что 2 целочисленных числа и что from < to, иначе задача не имеет решения
        public int GetLength()
        {
            return To - From + 1;
        }

        public bool IsInside(int number)
        {
            if(number >  From && number < To) return true;
            else return false;
        }
    }

    static void Main()
    {
        Range userRange = new Range { };
        Console.WriteLine("Введите первое число: ");
        userRange.From = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите последнее число: ");
        userRange.To = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Длина: {userRange.GetLength()}");
        Console.WriteLine("Введите число: ");
        Console.WriteLine($"Число находится в последовательности? {userRange.IsInside(Convert.ToInt32(Console.ReadLine()))}");
    }
}