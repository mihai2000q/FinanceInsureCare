using System.Reflection;
using DryIoc;
using MediatR;
using Prism.DryIoc;
using Prism.Ioc;

namespace FinanceInsureCare.Modules.Client.Business;

public static class DependencyInjection
{
    public static void AddBusiness(this IContainerRegistry containerRegistry)
    {
        var container = containerRegistry.GetContainer();

        container.Register<IMediator, Mediator>(Reuse.Singleton);

        container.RegisterMany(
            [typeof(IMediator).GetAssembly(), Assembly.GetExecutingAssembly()],
            Registrator.Interfaces);
        container.Register<IMediator, Mediator>(
            made: Made.Of(() => new Mediator(Arg.Of<IServiceProvider>())));
    }
}