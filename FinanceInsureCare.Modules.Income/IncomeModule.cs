using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Income.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Income;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class IncomeModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        ViewModelLocationProvider.Register<Views.Income, IncomeViewModel>();
        containerRegistry.RegisterForNavigation<Views.Income, IncomeViewModel>(ViewNames.IncomeView);
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
    }
}