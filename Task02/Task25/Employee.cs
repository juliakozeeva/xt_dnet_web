using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task25
{
    public class Employee : User
    {
        private string position;
        public string Position
        {
            get => position;
            set
            {
                if (CheckValue(value))
                    position = value;

            }
        }
        private int lengthOfService;
        public int LengthOfService
        {
            get => lengthOfService;
            set
            {
                if (CheckLengthOfService(value))
                    lengthOfService = value;
            }
        }

        private bool CheckLengthOfService(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Введенные данные некорректны.");
            return true;
        }

        public Employee(string name, string surname, string patronymic, DateTime bDay, string position, int lengthOfService)
            : base(name, surname, patronymic, bDay)
        {
            LengthOfService = lengthOfService;
            Position = position;
        }
    }
}
