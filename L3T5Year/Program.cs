//Задача Високосный год

int year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год невисокосный");
}
