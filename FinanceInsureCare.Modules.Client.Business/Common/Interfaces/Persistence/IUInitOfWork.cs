namespace FinanceInsureCare.Modules.Client.Business.Common.Interfaces.Persistence;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}