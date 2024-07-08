using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// pow 
    /// </summary>
    class Program
    {
        public static int GetPowRek(int x, int pow)
        {
            if(pow == 1)
            {
                return x;
            }

            return GetPowRek(x, pow - 1) * x;
        }

        public static int GetPowFor(int x, int pow)
        {
            int ans = 1;

            for (int i = 0; i < pow; i++) { 
                ans *= x;
            }

            return ans;
        }

        static void Main()
        {
            Console.WriteLine("Введите число и его степень");
            int x = Convert.ToInt32(Console.ReadLine());
            int pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPowRek(x, pow));
            Console.WriteLine(GetPowFor(x, pow));
        }
    }
}