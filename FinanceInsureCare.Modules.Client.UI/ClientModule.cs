using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Client.Business;
using FinanceInsureCare.Modules.Client.Persistence;
using FinanceInsureCare.Modules.Client.ViewModels;
using FinanceInsureCare.Modules.Client.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Client;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public sealed class ClientModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.AddBusiness();
        containerRegistry.AddPersistence();

        ViewModelLocationProvider.Register<Clients, ClientsViewModel>();
        containerRegistry.RegisterForNavigation<Clients, ClientsViewModel>(ViewNames.ClientsView);
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
    }
}