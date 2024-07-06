namespace Lesson3_1
{
    /// <summary>
    /// max
    /// </summary>
    class Program
    {
        static void Main()
        {
            double[] arr = {1,6,2,0,53,1,55,32 };

            Console.WriteLine("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double max = arr[0];

            int findedNumber = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] == number)
                {
                    findedNumber = i;
                }
            }

            Console.WriteLine($"Максимум {max}, нужное число индекс {findedNumber}");
        }
    }
}