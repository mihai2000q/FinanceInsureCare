using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Dashboard
{
    public class DashboardModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public DashboardModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}