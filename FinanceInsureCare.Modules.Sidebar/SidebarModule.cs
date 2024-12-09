using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Sidebar
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class SidebarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SidebarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<Views.Sidebar>(RegionNames.SidebarRegion);
        }
    }
}