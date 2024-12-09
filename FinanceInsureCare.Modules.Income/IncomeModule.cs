using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Income.ViewModels;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.Modules.Income
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class IncomeModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.Income, IncomeViewModel>(ViewNames.IncomeView);
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}