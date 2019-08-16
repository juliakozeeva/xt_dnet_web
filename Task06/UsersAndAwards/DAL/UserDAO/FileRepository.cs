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
    public class FileRepository : IStorable
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

        private static readonly string pathToAwards = "../../../storage/awards.txt";

        private static Dictionary<int, Award> FileWithAwards()
        {
            Dictionary<int, Award> awardsRepo = new Dictionary<int, Award>();
            var lines = File.ReadAllLines(pathToAwards);
            foreach (var line in lines)
            {
                int id = int.Parse(line.Split(' ')[0]);
                string title = line.Split(' ')[1];
                Award award = new Award
                {
                    Id = id,
                    Title = title,
                };

                awardsRepo.Add(int.Parse(line.Split(' ')[0]), award);
            }
            return awardsRepo;
        }

        private static readonly Dictionary<int, Award> RepositoryAwards = FileWithAwards();

        public void AddAward(Award award)
        {
            var lastId = RepositoryAwards.Any() ? RepositoryAwards.Keys.Max() : 0;
            award.Id = ++lastId;
            RepositoryAwards.Add(award.Id, award);
            File.AppendAllLines(pathToAwards, new[] { award.ToString() });
        }

        public bool DeleteAward(int id)
        {
            if (!RepositoryAwards.TryGetValue(id, out var award))
                throw new ArgumentOutOfRangeException($"Award {award} with id {id} not found.");
            RepositoryAwards.Remove(id);

            var afterDelete = RepositoryAwards.Values.Select(x => x.ToString()).ToArray();
            return true;
        }

        public IEnumerable<Award> GetAllAward()
        {
            if (RepositoryAwards.Values.Count == 0)
            {
                throw new ArgumentOutOfRangeException($"Award not exists.");
            }
            else
            {
                return RepositoryAwards.Values;
            }
        }
    }
}
