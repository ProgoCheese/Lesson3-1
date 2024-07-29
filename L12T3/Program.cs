namespace Lesson3_1
{
    class Program
    {
        static int CountOccurrences(string text, string searchString)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchString))
            {
                return 0;
            }

            text = text.ToLower();
            searchString = searchString.ToLower();

            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(searchString, index)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }


        /// <summary>
        /// я чет за тупил и сделал не по заданию зато это работает и это быстрее
        /// </summary>
        //public static int CountString(string file, string line)
        //{
        //    int count = 0;

        //    string[] word = file.Split(line, StringSplitOptions.RemoveEmptyEntries);

        //    if (file.EndsWith(line) && file.StartsWith(line))
        //    {
        //        count = word.Length - 1 + 2;
        //    }
        //    else if (file.EndsWith(line) || file.StartsWith(line))
        //    {
        //        count = word.Length - 1 + 1;
        //    }
        //    else
        //    {
        //        count = word.Length - 1;
        //    }

        //    return count;
        //}

        //zjszh 1 o 2 9 1 njklu 1 - это input и он есть

        static void Main()
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine()!;

            int count;

            using (StreamReader reader = new("input.txt"))
            {
                string file = reader.ReadLine()!;

                count = CountOccurrences(file, line);
            }

            Console.WriteLine("В файл входит " + count + " раз");
        }
    }
}