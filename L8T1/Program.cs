namespace Lesson3_1
{ 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            string userString = Console.ReadLine();

            int letterCount = 0;
            int digitCount = 0;
            int spaceCount = 0;
            int otherLetterCount = 0;

            for(int i = 0; i < userString.Length; i++)
            {
                char c = userString[i];

                if (char.IsWhiteSpace(c))
                {
                    spaceCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else
                {
                    otherLetterCount++;
                }
            }

            Console.WriteLine($"Букв {letterCount}, чисел {digitCount}, пробелов {spaceCount}, другие символы {otherLetterCount}");
        }
    }
}