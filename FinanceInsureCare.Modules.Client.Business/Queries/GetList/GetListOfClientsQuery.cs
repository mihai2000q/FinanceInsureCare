using FinanceInsureCare.Modules.Client.Domain;
using MediatR;

namespace FinanceInsureCare.Modules.Client.Business.Queries.GetList;

public sealed record GetListOfClientsQuery : IRequest<IEnumerable<ClientAggregate>>;