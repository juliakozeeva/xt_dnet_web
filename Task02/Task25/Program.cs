using System;
using System.Text.RegularExpressions;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Иван", "Иванов", "Иванович", new DateTime(1990, 12, 12));
            Console.WriteLine($"Фамилия: {user.Surname}");
            Console.WriteLine($"Имя: {user.Name}");
            Console.WriteLine($"Отчество: {user.Patronymic}");
            Console.WriteLine($"Дата Рождения: {user.BDay.ToShortDateString()}");
            Console.WriteLine($"Возраст: {user.getAge()}");

            Console.WriteLine();

            Employee employee = new Employee("Петр", "Петров", "", new DateTime(1990, 10, 12), "рекрутер", 6);
            Console.WriteLine($"Фамилия: {employee.Surname}");
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Отчество: {employee.Patronymic}");
            Console.WriteLine($"Дата Рождения: {employee.BDay.ToShortDateString()}");
            Console.WriteLine($"Возраст: {employee.getAge()}");
            Console.WriteLine($"Должность: {employee.Position}");
            Console.WriteLine($"Стаж работы (в месяцах): {employee.LengthOfService}");

            Console.ReadKey();
        }
    }
}
