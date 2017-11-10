namespace API.Repository
{
    using API.Interface;
    using API.Model;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System;

    public class UnitOfWork: IUnitOfWork
    {
        private readonly CARMEntities _dbContext;
        private Dictionary<string, object> _diRepository;
        private DbContextTransaction _tran;

        public UnitOfWork(CARMEntities dbContext)
        {
            this._dbContext = dbContext;
            this._diRepository = new Dictionary<string, object>();
        }

        public DbContextTransaction BeginTransaction()
        {
            this._tran = this._dbContext.Database.BeginTransaction();
            return this._tran;
        }

        public void Commit()
        {
            this._tran.Commit();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            var name = typeof(T).Name;
            if(!_diRepository.ContainsKey(name))
            {
                _diRepository.Add(name, System.Activator.CreateInstance(typeof(Repository<T>), _dbContext));
            }
            return _diRepository[name] as IRepository<T>;
        }

        public void Rollback()
        {
            this._tran.Rollback();
        }

        public int SaveChanges()
        {
            return this._dbContext.SaveChanges();
        }
    }
}
