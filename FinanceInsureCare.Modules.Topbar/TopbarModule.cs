using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Topbar.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Topbar;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TopbarModule(IRegionManager regionManager) : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        ViewModelLocationProvider.Register<Views.Topbar, TopbarViewModel>();
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        regionManager.RegisterViewWithRegion<Views.Topbar>(RegionNames.TopbarRegion);
    }
}