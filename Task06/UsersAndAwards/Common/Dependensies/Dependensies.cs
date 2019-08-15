using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.DAL;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Common
{
    public class Dependensies
    {
        public static IStorable<User> UsersRepository { get; } = new FileRepository();
    }
}
