using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Modules.Expense.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FinanceInsureCare.Modules.Expense
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ExpenseModule : IModule
    {

        private readonly IRegionManager _regionManager;

        public ExpenseModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<Expenses>(RegionNames.ExpensesRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
