namespace Lesson3_1
{
    /// <summary>
    /// Палиндром
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            string userString = Console.ReadLine();
            userString = userString.Replace(" ",String.Empty);
            userString = userString.Replace(",",String.Empty);
            Console.WriteLine(userString);

            int spaceKoefLeft = 0;
            int spaceKoefRight = 0;
            int halfLegth = (userString.Length + userString.Length % 2) / 2;

            bool isPalindrom = true;

            for (int i = 0; i < halfLegth; i++)
            {
                char leftChar = userString[i];
                char rightChar = userString[userString.Length - 1 - i];

                if (char.ToLower(leftChar) != char.ToLower(rightChar))
                {
                    isPalindrom = false;
                    //Console.WriteLine(leftChar + " = " + rightChar);
                    break;
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
        }
    }
}