namespace Lesson3_1
{
    /// <summary>
    /// параметры
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            foreach (string e in args)
            {
                Console.WriteLine(e);
            }
        }
    }
}