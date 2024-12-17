using FinanceInsureCare.Modules.Client.Business.Common.Interfaces.Persistence.Repository;
using FinanceInsureCare.Modules.Client.Domain;
using MediatR;

namespace FinanceInsureCare.Modules.Client.Business.Queries.GetList;

public sealed class GetListOfClientsQueryHandler(IClientRepository repository) 
    : IRequestHandler<GetListOfClientsQuery, IEnumerable<ClientAggregate>>
{
    public async Task<IEnumerable<ClientAggregate>> Handle(GetListOfClientsQuery query, CancellationToken cancellationToken)
    {
        var clients = await repository.GetList();
        return clients;
    }
}