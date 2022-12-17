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

        int currentEntrance = apartment / (floor * 4);
        int currentfloor = currentEntrance - ((currentEntrance - 1) * floor * 4) / 4;
        if(apartment > floor * entrance * 4)
        {
            Console.WriteLine("Такой квартиры нет.");
        }
        else
        {
            Console.WriteLine("Эта квартира");
        }
    }
}
