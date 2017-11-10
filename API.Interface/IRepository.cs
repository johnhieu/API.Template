namespace API.Interface
{
    using System.Collections.Generic;
    using System.Linq;
    public interface IRepository<T>
    {
        T GetById(object id);
        T Add(T obj);
        IEnumerable<T> Add(IEnumerable<T> objs);
        void Delete(T obj);
        void Delete(object id);

        void Update(T obj);
        IQueryable<T> Query();
        IQueryable<T> QueryAsNoTracking();
    }
}
