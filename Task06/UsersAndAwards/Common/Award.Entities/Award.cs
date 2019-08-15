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
        public Award(string title, string description, int Id = 0)
        {
            this.Id = Id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
