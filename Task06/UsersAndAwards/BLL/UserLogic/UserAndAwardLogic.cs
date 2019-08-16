using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Common;
using UsersAndAwards.Entities;

namespace UsersAndAwards.BLL
{
    public static class UserLogic 
    {
        public static IStorable Repository => Dependensies.UsersAndAwardsRepository;

        public static void AddUser(User user)
        {
            Repository.AddUser(user);
        }

        public static bool DeleteUser(int id)
        {
            try
            {
                return Repository.DeleteUser(id);
            }
            catch (ArgumentOutOfRangeException e)
            {

                throw new ArgumentException("Users not found.", "id", e);
            }
            
        }

        public static User GetByIdUser(int id)
        {
            try
            {
                return Repository.GetByIdUser(id);
            }
            catch (ArgumentOutOfRangeException e)
            {

                throw new ArgumentException("Users not found.", "id", e);
            }
            
        }

        public static IEnumerable<User> GetAllUser()
        {
            try
            {
                return Repository.GetAllUser();
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentException("Users not found.", e);
            }            
        }
        public static void AddAward(Award award)
        {
            Repository.AddAward(award);
        }
        public static bool DeleteAward(int id)
        {
            try
            {
                return Repository.DeleteAward(id);
            }
            catch (ArgumentOutOfRangeException e)
            {

                throw new ArgumentException("Award not found.", "id", e);
            }
        }
        public static IEnumerable<Award> GetAllAward()
        {
            try
            {
                return Repository.GetAllAward();
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentException("Award not found.", e);
            }
        }
    }
}
