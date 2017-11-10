namespace API.Template.Controllers
{
    using System.Web.Http;
    using System.Collections.Generic;
    using API.Service.Service_Model;
    using API.Service.Service_Interfaces;
    public class WarehouseController : ApiController
    {
        private readonly IWarehouseSvc _WarehouseSvc;
        public WarehouseController(IWarehouseSvc WarehouseSvc)
        {
            this._WarehouseSvc = WarehouseSvc;
        }
        
        [HttpGet]
        [Route("Warehouse/GetWarehouseById")]
        public IHttpActionResult GetWarehouseById(string id)
        {
            return Ok(this._WarehouseSvc.GetByWarehouseId(id));
        }

        [HttpGet]
        [Route("Warehouse/GetWarehouses")]
        public IHttpActionResult GetWarehouses()
        {
            return Ok(this._WarehouseSvc.GetWarehouses());
        }

    }
}