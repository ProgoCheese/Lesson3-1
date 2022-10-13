
class Program
{
    static void Main()
    {
        //Задача Пароль

        string password = Console.ReadLine();
        string userPassword = Console.ReadLine();
        if (password.Equals(userPassword))
        {
            if (password == userPassword)
            {
                Console.WriteLine("пароль верный");
            }
            else
            {
                Console.WriteLine("пароль неверный");
            }
        }
        else if (password.Length < userPassword.Length)
        {
            Console.WriteLine("пароль неверный и слишком короткый");
        }
        else
        {
            Console.WriteLine("пароль неверный и слишком длинный");
        };
    }
}