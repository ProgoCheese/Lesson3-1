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
                while ((file = reader.ReadLine()!) != null)
                {
                    if (countLine < lines.Length - 1)
                    {
                        lines[countLine] = file.ToUpper();
                        countLine++;
                    }
                }

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    for (int i = 0; i < countLine; i++)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
        }
    }
}