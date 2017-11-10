namespace API.Service.Service_Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using API.Model;
    using API.Service.Service_Interfaces;
    using API.Service.Service_Model;
    using API.Interface;
    using AutoMapper.QueryableExtensions;
    public class WarehouseSvc: BaseSvc<Warehouse>, IWarehouseSvc
    {
        public WarehouseSvc(IUnitOfWork uow) : base(uow) { }

        private IQueryable<WarehouseSM> Get()
        {
            return this._repo.Query().ProjectTo<WarehouseSM>();
        }

        public WarehouseSM GetByWarehouseId(string id)
        {
            return Get().FirstOrDefault(x => x.WHOUSE_ID == id);
        }

        public IEnumerable<WarehouseSM> GetWarehouses()
        {
            return Get().AsEnumerable();
        }

    }
}
