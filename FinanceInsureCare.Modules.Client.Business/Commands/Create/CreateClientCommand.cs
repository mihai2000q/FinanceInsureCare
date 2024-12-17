using FinanceInsureCare.Modules.Client.Business.Common.Response;
using MediatR;

namespace FinanceInsureCare.Modules.Client.Business.Commands.Create;

public sealed record CreateClientCommand(string Name) : IRequest<MessageResponse>;