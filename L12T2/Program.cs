using System.Text;

namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите url");
            string url = Console.ReadLine()!;

            int index = url.IndexOf("://");
            int idEnd = url.IndexOf("/", index + 3);

            if (idEnd == -1)
            {
                Console.WriteLine("Имя сервера: " + url.Substring(index + 3));
            }
            else
            {
                Console.WriteLine("Имя сервера: " + url.Substring(index + 3, idEnd - index - 3));
            }
        }
    }
}