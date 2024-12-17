using FinanceInsureCare.Modules.Client.Business.Common.Interfaces.Persistence;
using FinanceInsureCare.Modules.Client.Business.Common.Interfaces.Persistence.Repository;
using FinanceInsureCare.Modules.Client.Business.Common.Response;
using FinanceInsureCare.Modules.Client.Domain;
using MediatR;

namespace FinanceInsureCare.Modules.Client.Business.Commands.Create;

public sealed class CreateClientCommandHandler(IClientRepository repository, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateClientCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateClientCommand command, CancellationToken cancellationToken)
    {
        var client = new ClientAggregate
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
        };
        await repository.Add(client);
        await unitOfWork.SaveChangesAsync();

        return new MessageResponse("Client created!");
    }
}