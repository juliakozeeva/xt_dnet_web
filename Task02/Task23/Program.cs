using System;
using System.Text.RegularExpressions;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Иван", "Иванов", "Иванович", new DateTime(1994, 12, 22));
            Console.WriteLine($"Фамилия: {user.Surname}");
            Console.WriteLine($"Имя: {user.Name}");
            Console.WriteLine($"Отчество: {user.Patronymic}");
            Console.WriteLine($"Дата Рождения: {user.BDay.ToShortDateString()}");
            Console.WriteLine($"Возраст: {user.getAge()}");

            Console.ReadKey();
        }
    }
}
