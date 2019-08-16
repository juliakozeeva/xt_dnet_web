using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<User> Users { get; set; } = new List<User>();
        public Award() { }
        public Award(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
