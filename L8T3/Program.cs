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
            string userString = Console.ReadLine()!;

            int left = 0;
            int right = userString.Length - 1;

            bool isPalindrom = true;

            while (left <= right)
            {
                char leftChar = userString[left];
                char rightChar = userString[right];

                while (!char.IsLetterOrDigit(leftChar))
                {
                    left++;
                    leftChar = userString[left];
                }

                while (!char.IsLetterOrDigit(rightChar))
                {
                    right--;
                    rightChar = userString[right];
                }

                if (char.ToLower(leftChar) != char.ToLower(rightChar))
                {
                    isPalindrom = false;
                    //Console.WriteLine(leftChar + " = " + rightChar);
                    break;
                }

                left++;
                right--;
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