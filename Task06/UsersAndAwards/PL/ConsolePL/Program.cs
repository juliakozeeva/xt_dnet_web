﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.BLL;
using UsersAndAwards.Common;
using UsersAndAwards.Entities;

namespace ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            AppStart();
        }
        public static void AppStart ()
        {            
            Console.WriteLine("Choose next action:");
            do
            {
                Console.WriteLine(Environment.NewLine + string.Join("\n", menuHelp));
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {
                    do
                    {
                        AddUser();
                        Console.WriteLine("Add another user? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                else if (key == ConsoleKey.D2)
                {
                    do
                    {
                        DeleteUser();
                        Console.WriteLine("Delete another user? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                else if (key == ConsoleKey.D3)
                {
                    do
                    {
                        ShowUserByID();
                        Console.WriteLine("View another id? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                else if (key == ConsoleKey.D4)
                {
                        ShowUsers();
                }
                else if (key == ConsoleKey.D5)
                {
                    do
                    {
                        AddAward();
                        Console.WriteLine("Add another award? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                else if (key == ConsoleKey.D6)
                {
                    do
                    {
                        DeleteAward();
                        Console.WriteLine("Delete another award? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                else if (key == ConsoleKey.D7)
                {
                    ShowAwards();
                }
                else if (key == ConsoleKey.D8)
                {
                    do
                    {
                        AwardUser();
                        Console.WriteLine("Award another user? (y/n)");
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);
                }
                Console.WriteLine("\nDo another action? (y/n)");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);
        }

        private static void AddUser()
        {
            Console.WriteLine("\nEnter the information about user.");
            string name;
            while (true)
            {
                Console.Write("First name: ");
                name = Console.ReadLine();
                if (name == "")
                    Console.WriteLine("Data must be field. Try again.");
                else break;
            }
            DateTime dateOfBirth;
            while (true)
            {
                Console.Write("Date of birth: ");
                dateOfBirth = DateTime.Parse(Console.ReadLine());
                if ((dateOfBirth.Year < 1900) || (dateOfBirth.Year > DateTime.Now.Year))
                {
                    Console.WriteLine("Invalid date of birth.");
                }
                else break;
            }
            var user = new User(name, dateOfBirth);
            UserLogic.AddUser(user);
        }

        private static void DeleteUser()
        {
            Console.WriteLine("\nEnter ID deleted user.");
            int id = int.Parse(Console.ReadLine());
            UserLogic.DeleteUser(id);
            Console.WriteLine($"User was deleted.");

        }

        private static void ShowUserByID()
        {
            Console.WriteLine("\nEnter user ID.");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(UserLogic.GetByIdUser(id));

        }

        private static void ShowUsers()
        {
            Console.WriteLine("\n");
            foreach (var user in UserLogic.GetAllUser())
            {
                Console.WriteLine(user);
            }
        }
        private static void AddAward()
        {
            Console.WriteLine("\nEnter the information about award.");
            string title;
            while(true)
            {
                Console.Write("Title: ");
                title = Console.ReadLine();
                if (title == "")
                    Console.WriteLine("Data must be field. Try again.");
                else break;
            }
            var award = new Award(title);
            UserLogic.AddAward(award);
        }

        private static void DeleteAward()
        {
            Console.WriteLine("\nEnter ID deleted award.");
            int id = int.Parse(Console.ReadLine());
            UserLogic.DeleteAward(id);
            Console.WriteLine($"Award was deleted.");

        }
        private static void ShowAwards()
        {
            Console.WriteLine("\n");
            foreach (var award in UserLogic.GetAllAward())
            {
                Console.WriteLine(award);
            }
        }

        private static void AwardUser()
        {
            Console.WriteLine("\nChoose user for award: ");
            ShowUsers();
            int idUser = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose award for user: ");
            ShowAwards();
            int idAward = int.Parse(Console.ReadLine());
            UserLogic.AwardUser(idAward, idUser);
            ShowUsers();
        }

        static string[] menuHelp = new string[]  {

            "Users:",
            "\t1. Add user",
            "\t2. Delete user",
            "\t3. Show user by id",
            "\t4. Show all users",
            "Awards:",
            "\t5. Add award",
            "\t6. Delete award",
            "\t7. Show all awards",
            "Users and Awards",
            "\t8. Award user",

        };
    }
}
