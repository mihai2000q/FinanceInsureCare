using FinanceInsureCare.Modules.Client.Domain;

namespace FinanceInsureCare.Modules.Client.Business.Common.Interfaces.Persistence.Repository;

public interface IClientRepository
{
    Task<List<ClientAggregate>> GetList();
    
    Task Add(ClientAggregate client);
}