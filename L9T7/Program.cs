using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// max
    /// </summary>
    class Program
    {
        public static void GetUpperstring(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            { 
                s[i] = s[i].ToUpper();
            }
        }

        static void Main()
        {
            string[] arr = { " dafiEeijd ", " ФУАщрф ", " FWEFFSEFsf ", " zsdfGFsd ", " SEsdAEDg ", "afdagas " };

            GetUpperstring(arr);

            foreach (string e in arr)
            {
                Console.Write(e);
            }

        }
    }
}