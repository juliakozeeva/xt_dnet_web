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
        public List<string> Users { get; set; } = new List<string>();
        public Award() { }
        public Award(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
