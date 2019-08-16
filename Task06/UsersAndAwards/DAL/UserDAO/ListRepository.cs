using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class ListRepository : IStorable
    {
        private static Dictionary<int, User> UsersList { get; set; }
        public ListRepository()
        {
            UsersList = new Dictionary<int, User>();
        }

        public void AddUser(User user)
        {
            var lastId = UsersList.Any() ? UsersList.Keys.Max() : 0;
            user.Id = ++lastId;
            UsersList.Add(user.Id, user);
        }

        public bool DeleteUser(int id)
        {
            if (!UsersList.TryGetValue(id, out var user))
                throw new ArgumentOutOfRangeException($"Users {user} with id {id} not found.");
            UsersList.Remove(id);

            var afterDelete = UsersList.Values.Select(x => x.ToString()).ToArray();
            return true;
        }

        public IEnumerable<User> GetAllUser()
        {
            if(UsersList.Values.Count == 0)
            {
                throw new ArgumentOutOfRangeException($"Users not exists.");
            }
            return UsersList.Values;
        }

        public User GetByIdUser(int id)
        {
            if (!UsersList.TryGetValue(id, out var user))
                throw new ArgumentOutOfRangeException($"Users with id {id} not found.");
            return user;
        }

        private static Dictionary<int, Award> AwardsList { get; set; } = new Dictionary<int, Award>();

        public void AddAward(Award award)
        {
            var lastId = AwardsList.Any() ? AwardsList.Keys.Max() : 0;
            award.Id = ++lastId;
            AwardsList.Add(award.Id, award);
        }

        public bool DeleteAward(int id)
        {
            if (!AwardsList.TryGetValue(id, out var award))
                throw new ArgumentOutOfRangeException($"Award {award} with id {id} not found.");
            AwardsList.Remove(id);

            var afterDelete = AwardsList.Values.Select(x => x.ToString()).ToArray();
            return true;
        }

        public IEnumerable<Award> GetAllAward()
        {
            if (AwardsList.Values.Count == 0)
            {
                throw new ArgumentOutOfRangeException($"Awards not exists.");
            }
            return AwardsList.Values;
        }
    }
}
