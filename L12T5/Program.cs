namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            string[] lines = new string[100];

            string file;

            int linesCount = 0;

            using (StreamReader reader = new("input.txt"))
            {
                while ((file = reader.ReadLine()!) != null)
                {
                    if (linesCount < lines.Length - 1)
                    {
                        lines[linesCount] = file;
                        linesCount++;
                    }
                }
            }

            for (int i = 0; i < linesCount; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}