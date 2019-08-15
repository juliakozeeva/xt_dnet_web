using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepositoryDAO<T> where T : class 
    {
        void Add(T item);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
