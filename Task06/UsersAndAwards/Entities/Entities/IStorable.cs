using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IStorable<T>
    {
        void AddUser(T item);
        bool DeleteUser(int id);
        T GetByIdUser(int id);
        IEnumerable<T> GetAllUser();
    }
}
