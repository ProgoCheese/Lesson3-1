using System.Text;

namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            StringBuilder myString = new();

            myString.Append(1);

            for (int i = 2; i <= 100; i++)
            {
                myString.Append(", ")
                    .Append(i);
            }

            Console.WriteLine(myString.ToString());
        }
    }
}