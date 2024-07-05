class Program
{
   public class Contact
   {
        public string Name { get; set; }
        public string Surname { get; set; }

        public double Numders { get; set; }
   }

    static void Main()
    {
        Contact user = new Contact();
        user.Name = "Andrei";
        user.Surname = "Ivanov";
        user.Numders = 89839245029;
        Console.WriteLine($"Имя: {user.Name}, Фамилия: {user.Surname}, Номер: {user.Numders}.");
        Contact friend = new Contact();
        friend.Name = "Петя";
        friend.Surname = "Петров";
        friend.Numders = 9712397087;
        Console.WriteLine($"Имя: {friend.Name}, Фамилия: {friend.Surname}, Номер: {friend.Numders}.");
    }
} 