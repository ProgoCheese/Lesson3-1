/// <summary>
/// Квартиры
/// </summary>
class Program
{
    static void Main()
    {
        Console.Write("Введите число этажей : ");
        int floor = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число подъездов : ");
        int entrance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите нужную квартиру : ");
        int apartment = Convert.ToInt32(Console.ReadLine());

        int currentEntrance = (apartment - 1 ) / (floor * 4) + 1;
        int currentfloor = (apartment - ((currentEntrance - 1) * floor * 4) - 1) / 4 + 1;
        int apartmentPos = apartment % 4;

        if (apartment > floor * entrance * 4)
        {
            Console.WriteLine("Такой квартиры нет.");
        }
        else
        {
            Console.WriteLine("Эта квартира находится в подъедзе № " + currentEntrance + " на " + currentfloor + " этаже и это квартира ");

            switch (apartmentPos)
            {
                case 0:
                    Console.Write("ближняя справа");
                    break;
                case 1:
                    Console.Write("ближняя слева");
                    break;
                case 2:
                    Console.Write("дальняя слева");
                    break;
                case 3:
                    Console.Write("дальняя справа");
                    break;
            }
        }
    }
}
