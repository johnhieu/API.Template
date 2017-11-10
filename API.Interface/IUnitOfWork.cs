namespace API.Interface
{
    using System.Data.Entity;
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T: class;
        int SaveChanges();
        DbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();
    }
}
