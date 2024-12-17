namespace FinanceInsureCare.Modules.Client.Domain;

public sealed class ClientAggregate
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}