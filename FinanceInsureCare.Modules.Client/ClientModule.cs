using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Client.ViewModels;
using FinanceInsureCare.Modules.Client.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Client
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ClientModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<Clients, ClientsViewModel>();
            containerRegistry.RegisterForNavigation<Clients, ClientsViewModel>(ViewNames.ClientsView);
        }
        
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
