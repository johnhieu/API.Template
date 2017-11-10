namespace API.Service
{
    using API.Interface;
    using System;
    public class BaseSvc<T> : IDisposable where T : class
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IRepository<T> _repo;

        public BaseSvc(IUnitOfWork uow)
        {
            this._uow = uow;
            this._repo = this._uow.Repository<T>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
