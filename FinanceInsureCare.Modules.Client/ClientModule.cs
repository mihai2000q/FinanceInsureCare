using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Client.ViewModels;
using FinanceInsureCare.Modules.Client.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.Modules.Client
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ClientModule : IModule
    {
        
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Clients, ClientsViewModel>(ViewNames.ClientsView);
        }
    }
}
