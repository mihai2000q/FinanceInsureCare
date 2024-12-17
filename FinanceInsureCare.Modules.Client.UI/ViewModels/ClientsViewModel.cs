using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FinanceInsureCare.Modules.Client.Business.Queries.GetList;
using FinanceInsureCare.Modules.Client.Domain;
using MediatR;
using Prism.Mvvm;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Client.ViewModels;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
internal sealed class ClientsViewModel(ISender mediator) : BindableBase, IConfirmNavigationRequest
{
    private string _message = "Clients View";
    private ObservableCollection<ClientAggregate> _clients = [];

    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value);
    }

    public ObservableCollection<ClientAggregate> Clients
    {
        get => _clients;
        set => SetProperty(ref _clients, value);
    }
    
    public void OnNavigatedTo(NavigationContext navigationContext)
    {
        Task.Run(async () =>
        {
            var clients = await mediator.Send(new GetListOfClientsQuery());
            Clients = new ObservableCollection<ClientAggregate>(clients);
        });
    }

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return true;
    }

    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
    {
    }
}