﻿namespace Lesson3_1
{
    /// <summary>
    /// max
    /// </summary>
    class Program
    {
        public static void GetUpperString(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].ToUpper();
            }
        }

        static void Main()
        {
            string[] array = { " dafiEeijd ", " ФУАщрф ", " FWEFFSEFsf ", " zsdfGFsd ", " SEsdAEDg ", "afdagas " };

            GetUpperString(array);

            foreach (string e in array)
            {
                Console.Write(e);
            }
        }
    }
}