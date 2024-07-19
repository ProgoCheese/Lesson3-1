using System.Text;

namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string line = "1,2,3,4,5";
            string[] numbers = line .Split(",", StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string number in numbers)
            {
                sum += Convert.ToInt32(number);                
            }

            

            Console.WriteLine("Сумма " + sum);
        }
    }
}