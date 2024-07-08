using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int BinarySearch(int[] a, int left, int right, int x)
        {
            if (left > right)
            {
                return -1;
            }
            
            int middle = (right + left) / 2;

            if (a[middle] == x)
            {
                return middle;
            }
            else if(a[middle] < x)
            {
                return BinarySearch(a, middle + 1, right, x);
            }
            else
            {
                return BinarySearch(a, left, middle - 1, x);
            }
        }

        public static int BinarySearchFor(int[] a, int left, int right, int x)
        {
            int b = -1;
            
            while (!(left > right))
            {
                int middle = (right + left) / 2;
 
                if (a[middle] == x)
                {
                    b = middle;
                    break;
                }
                else if (a[middle] < x)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                    //Console.WriteLine(middle);
                }
               // Console.WriteLine(right);
            }

            return b;
        }

        static void Main()
        {
            int[] a = { 1, 2, 5, 8, 9, 12, 65, 67, 129 };

            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(BinarySearch(a, 0, a.Length-1,x));
            Console.WriteLine(BinarySearchFor(a, 0, a.Length-1,x));
        }
    }
}