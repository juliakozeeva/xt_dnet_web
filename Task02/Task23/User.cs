using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task23
{
    public class User
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (CheckValue(value))
                    name = value;
            }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set
            {
                if (CheckValue(value))
                    surname = value;
            }
        }
        private string patronymic;
        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (CheckValue(value, true))
                    patronymic = value;
            }
        }
        private DateTime bDay;

        public DateTime BDay
        {
            get => bDay;
            set
            {
                if (CheckDBday(value))
                    bDay = value;
                else throw new Exception("Дата рождения превышает 100 лет жизни");
            }
        }

        private bool CheckValue(string value, bool couldBeEmpty = false)
        {
            const string namePattern = @"[0-9!-?/.,;:_=+]+";
            if (value == null)
                throw new ArgumentNullException();
            if (value.Length == 0)
                if (couldBeEmpty)
                    return true;
                else
                    throw new ArgumentException("Данные должны быть заполнены.");
            if (Regex.IsMatch(value, namePattern))
                throw new ArgumentException("Данные должны состоять из букв.");

            return true;
        }

        private bool CheckDBday(DateTime BDay)
        {
            DateTime now = DateTime.Now;
            int dif = Math.Abs(now.Year - BDay.Year);
            if (dif <= 100)
                return true;
            return false;
        }


        public int getAge()
        {
            DateTime now = DateTime.Now;
            return now.Year - this.bDay.Year;
        }

        public User(string name, string surname, string patronymic, DateTime bDay)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BDay = bDay;
        }
    }
}
