using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Modules.Client.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Client
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ClientModule : IModule
    {

        private readonly IRegionManager _regionManager;

        public ClientModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<Clients>(RegionNames.ClientsRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
