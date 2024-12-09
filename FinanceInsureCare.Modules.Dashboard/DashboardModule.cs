using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Dashboard.ViewModels;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.Modules.Dashboard
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class DashboardModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.Dashboard, DashboardViewModel>(ViewNames.DashboardView);
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}