namespace API.Repository
{
    using API.Interface;
    using API.Model;
    using Unity;
    using System.Data.Entity;
    using Unity.Lifetime;
    public class Startup: IStartup
    {
        private IUnityContainer _unityContainer;

        public Startup(IUnityContainer unityContainer)
        {
            this._unityContainer = unityContainer;
        }

        public void Register()
        {
            _unityContainer.RegisterType<DbContext, CARMEntities>();
        }
    }
}
