using System.Text;

namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            StringBuilder mySting = new StringBuilder();

            mySting.Append(1);

            for (int i = 2; i <= 100; i++)
            {
                mySting.Append(",")
                    .Append(i);
            }

            Console.WriteLine(mySting.ToString());
        }
    }
}