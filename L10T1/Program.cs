namespace Lesson3_1
{
    /// <summary>
    /// pow 
    /// </summary>
    class Program
    {
        public static int GetPowByRecursion(int number, int degree)
        {
            if (degree == 1)
            {
                return number;
            }

            return GetPowByRecursion(number, degree - 1) * number;
        }

        public static int GetPowFor(int number, int degree)
        {
            int ans = 1;

            for (int i = 0; i < degree; i++)
            {
                ans *= number;
            }

            return ans;
        }

        static void Main()
        {
            Console.WriteLine("Введите число и его степень");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите степень");
            int degree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Число в степени равно = " + GetPowByRecursion(number, degree));
            Console.WriteLine("Число в степени равно = " + GetPowFor(number, degree));
        }
    }
}