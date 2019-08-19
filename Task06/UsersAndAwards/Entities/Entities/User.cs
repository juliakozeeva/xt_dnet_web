using UsersAndAwards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsersAndAwards.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }        

        public User() { }

        public User(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if ((DateTime.Now.Month <= DateOfBirth.Month) && (DateTime.Now.Day < DateOfBirth.Day))
                    age--;
                return age;
            }
        }

        public List<string> Awards { get; set; } = new List<string>();
        public string AwardsString => string.Join(", ", Awards);

        public override string ToString()
        {
            return $"{Id} {Name} {DateOfBirth.ToShortDateString()} {Age} {AwardsString}";
        }
    }
}
