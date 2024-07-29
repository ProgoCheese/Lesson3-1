namespace Lesson3_1
{
    class Program
    {
        static void Main()
        {
            string[] lines = new string[100];

            string file;

            int countLine = 0;

            using StreamReader reader = new("input.txt");
            using StreamWriter writer = new("output.txt");

            while ((file = reader.ReadLine()!) != null)
            {
                if (countLine < lines.Length - 1)
                {
                    writer.WriteLine(file.ToUpper());
                }
            }
        }
    }
}