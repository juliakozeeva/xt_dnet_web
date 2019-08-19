using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UsersAndAwards.DAL;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class FileRepository : IStorable
    {
        private static readonly string pathToUsers = "../../../storage/users.txt";

        private static Dictionary<int, User> FileWithUsers ()
        {
            Dictionary<int, User> usersRepo = new Dictionary<int, User>();
            var lines = File.ReadAllLines(pathToUsers);
            foreach (var line in lines)
            {
                List<string> splitLine = new List<string>(line.Split(' '));
                int id = int.Parse(splitLine[0]);
                string name = splitLine[1];
                DateTime dateOfBirth = DateTime.Parse(splitLine[2]);
                List<string> awards = new List<string>();
                for (int i = 4; i < splitLine.Count(); i++)
                {
                    awards.Add(Regex.Replace(splitLine[i], ",", ""));
                }
                User user = new User
                {
                    Id = id,
                    Name = name,
                    DateOfBirth = dateOfBirth,
                    Awards = awards
                };

                usersRepo.Add(int.Parse(splitLine[0]), user);
            }
            return usersRepo;
        }

        private static readonly Dictionary<int, User> RepositoryUsers = FileWithUsers();

        public void AddUser(User user)
        {
            var lastId = RepositoryUsers.Any() ? RepositoryUsers.Keys.Max() : 0;
            user.Id = ++lastId;
            RepositoryUsers.Add(user.Id, user);
            File.AppendAllLines(pathToUsers, new[] { user.ToString() });
        }

        public bool DeleteUser(int id)
        {
            if (!RepositoryUsers.TryGetValue(id, out var user))
                throw new ArgumentOutOfRangeException($"Users {user} with id {id} not found.");
            RepositoryUsers.Remove(id);

            var afterDelete = RepositoryUsers.Values.Select(x => x.ToString()).ToArray();
            File.WriteAllLines(pathToUsers, afterDelete);
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
                string[] splitLine = line.Split(' ');
                int id = int.Parse(splitLine[0]);
                string title = splitLine[1];
                Award award = new Award
                {
                    Id = id,
                    Title = title,
                };

                awardsRepo.Add(int.Parse(splitLine[0]), award);
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
            File.WriteAllLines(pathToAwards, afterDelete);
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

        public Award GetByIdAward(int id)
        {
            if (!RepositoryAwards.TryGetValue(id, out var award))
                throw new ArgumentOutOfRangeException($"Awards with id {id} not found.");
            return award;
        }

        public void AwardUser(int idAward, int idUser)
        {
            Award award = null;
            User user = null;

            if (RepositoryUsers.TryGetValue(idUser, out var value1))
            {
                user = value1;
            }
            if (RepositoryAwards.TryGetValue(idAward, out var value2))
            {
                award = value2;
            }
            if (!user.Awards.Contains(award.Title))
            {
                award.Users.Add(user.Name);
                user.Awards.Add(award.Title);

                File.WriteAllText(pathToAwards, string.Empty);
                foreach (var item in RepositoryAwards.Values)
                {

                    File.AppendAllLines(pathToAwards, new[] { item.ToString() });
                }

                File.WriteAllText(pathToUsers, string.Empty);
                foreach (var item in RepositoryUsers.Values)
                {
                    File.AppendAllLines(pathToUsers, new[] { item.ToString() });
                }
            }
            else
            {
                Console.WriteLine("User has got this award already");
            }
        }
    }
}
