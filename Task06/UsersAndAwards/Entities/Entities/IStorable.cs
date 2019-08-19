using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace Entities
{
    public interface IStorable
    {
        void AddUser(User user);
        bool DeleteUser(int id);
        User GetByIdUser(int id);
        IEnumerable<User> GetAllUser();

        void AddAward(Award award);
        bool DeleteAward(int id);
        IEnumerable<Award> GetAllAward();
        Award GetByIdAward(int id);

        void AwardUser(int idAward, int idUser);

    }
}
