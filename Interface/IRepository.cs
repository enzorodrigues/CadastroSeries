using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface IRepository<T>
    {
        List<T> List();
        T getId(int id);        
        void Insert(T entity);        
        void Delete(int id);        
        void Update(int id, T entity);
        int NextId();
    }
}