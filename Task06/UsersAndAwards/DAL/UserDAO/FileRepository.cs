using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.DAL;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class FileRepository : IStorable<User>
    {
        private static readonly string path = "../../../storage/users.txt";

        private static Dictionary<int, User> FileWithUsers ()
        {
            Dictionary<int, User> usersRepo = new Dictionary<int, User>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                int id = int.Parse(line.Split(' ')[0]);
                string name = line.Split(' ')[1];
                DateTime dateOfBirth = DateTime.Parse(line.Split(' ')[2]);
                User user = new User
                {
                    Id = id,
                    Name = name,
                    DateOfBirth = dateOfBirth,
                };

                usersRepo.Add(int.Parse(line.Split(' ')[0]), user);
            }
            return usersRepo;
        }

        private static readonly Dictionary<int, User> RepositoryUsers = FileWithUsers();

        public void AddUser(User user)
        {
            var lastId = RepositoryUsers.Any() ? RepositoryUsers.Keys.Max() : 0;
            user.Id = ++lastId;
            RepositoryUsers.Add(user.Id, user);
            File.AppendAllLines(path, new[] { user.ToString() });
        }

        public bool DeleteUser(int id)
        {
            if (!RepositoryUsers.TryGetValue(id, out var user))
                throw new ArgumentOutOfRangeException($"Users {user} with id {id} not found.");
            RepositoryUsers.Remove(id);

            var afterDelete = RepositoryUsers.Values.Select(x => x.ToString()).ToArray();
            return true;
        }

        public IEnumerable<User> GetAllUser()
        {
            if (RepositoryUsers.Values.Count == 0)
            {
                throw new ArgumentOutOfRangeException($"Users not exists.");
            }
            else
            {
                return RepositoryUsers.Values;
            }
            
        }

        public User GetByIdUser(int id)
        {
            if (!RepositoryUsers.TryGetValue(id, out var user))
                throw new ArgumentOutOfRangeException($"Users with id {id} not found.");
            return user;
        }
    }
}
