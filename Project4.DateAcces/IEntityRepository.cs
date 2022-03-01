using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DateAcces
{
    //class ---- reference types interface cannot be new Tmust be class cannot be interfaces dedik
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();

        List<T> GetById(int id);

        void Add(T entity);

        void Update(T customer);

        void Delete(T entity);
    }
}
