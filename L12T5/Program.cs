using System.Text;

namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            string[] lines = new string[100];

            string file;

            int countLine = 0;

            using (StreamReader reader = new StreamReader("input.txt"))
            {
                while((file= reader.ReadLine()!) != null)
                {
                    if (countLine < lines.Length - 1)
                    {
                        lines[countLine] = file;
                        countLine++;
                    }
                }
            }


            for(int i = 0; i < countLine; i++) 
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}