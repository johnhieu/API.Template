namespace API.Repository
{
    using System;
    using API.Interface;
    using API.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    public class Repository<T> : IRepository<T> where T : class
    {
        internal CARMEntities _dbContext;
        internal DbSet<T> dbSet;

        public Repository(CARMEntities dbContext)
        {
            this._dbContext = dbContext;
            this.dbSet = this._dbContext.Set<T>();
        }
        public T Add(T obj)
        {
            return this.dbSet.Add(obj);
        }

        public IEnumerable<T> Add(IEnumerable<T> objs)
        {
            var results = new List<T>();
            foreach(var obj in objs)
            {
                results.Add(this.Add(obj));
            }
            return results;
        }

        public void Delete(T obj)
        {
            if(this._dbContext.Entry(obj).State == EntityState.Detached)
            {
                dbSet.Attach(obj);
            }
            dbSet.Remove(obj);
        }

        public void Delete(object id)
        {
            T entityToDelete = this.dbSet.Find(id);
            this.Delete(entityToDelete);
        }

        public T GetById(object id)
        {
            return this.dbSet.Find(id);
        }

        public IQueryable<T> Query()
        {
            return this.dbSet.AsQueryable();
        }

        public IQueryable<T> QueryAsNoTracking()
        {
            return this.dbSet.AsNoTracking().AsQueryable();
        }

        public void Update(T obj)
        {
            this.dbSet.Attach(obj);
            this._dbContext.Entry(obj).State = EntityState.Modified;
        }
    }
}
