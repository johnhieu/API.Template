namespace API.Service
{
    using API.Interface;
    using API.Model;
    using API.Repository;
    using Unity;
    using Unity.Lifetime;
    using API.Service.Service_Implementation;
    using API.Service.Service_Model;
    using API.Service.Service_Interfaces;

    public class Startup: IStartup
    {
        private IUnityContainer _unityContainer;
        public Startup(IUnityContainer unityContainer)
        {
            this._unityContainer = unityContainer;
        }

        public void Register()
        {
            #region inject services
            // Create the rest of the services and registerType here
            _unityContainer.RegisterType<IUnitOfWork, UnitOfWork>(new PerThreadLifetimeManager());
            _unityContainer.RegisterType<IWarehouseSvc, WarehouseSvc>(new PerThreadLifetimeManager());

            #endregion

            #region auto mapper
            AutoMapper.Mapper.Initialize(config =>
            {
                // Add the rest of the service models here
                config.CreateMap<WarehouseSM, Warehouse>().ReverseMap();
            });
            #endregion
        }
    }
}
