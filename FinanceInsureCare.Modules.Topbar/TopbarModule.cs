using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Topbar
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class TopbarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public TopbarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<Views.Topbar>(RegionNames.TopbarRegion);
        }
    }
}