namespace API.Service.Service_Interfaces
{
    using API.Service.Service_Model;
    using System.Collections.Generic;

    public interface IWarehouseSvc
    {
        WarehouseSM GetByWarehouseId(string id);
        IEnumerable<WarehouseSM> GetWarehouses();
    }
}
