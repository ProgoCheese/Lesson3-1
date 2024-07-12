namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int GetGCF(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GetGCF(b, a % b);
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите 2 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Их НОД равен " + GetGCF(a, b));
        }
    }
}