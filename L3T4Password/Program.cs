﻿/// <summary>
/// Задача Пароль
/// </summary>
class Program
{
    static bool isDo = true;

    static void Main()
    {
        while (isDo)
        {
            CheckPassword();
        }
    }

    static void CheckPassword()
    {
        string password = "1234";

        Console.Write("Введите пароль: ");
        string userPassword = Console.ReadLine();

        if (userPassword == "n")
        {
            isDo = false;
            return;
        }

        if (password == userPassword)
        {
            Console.WriteLine("пароль верный");
        }
        else if (password.Length > userPassword.Length)
        {
            Console.WriteLine("пароль неверный и слишком короткый");
        }
        else if (password.Length < userPassword.Length)
        {
            Console.WriteLine("пароль неверный и слишком длинный");
        }
        else
        {
            Console.WriteLine("пароль неверный");
        }
    }
}