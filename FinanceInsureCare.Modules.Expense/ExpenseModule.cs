using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Expense.ViewModels;
using FinanceInsureCare.Modules.Expense.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Expense
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ExpenseModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<Expenses, ExpensesViewModel>();
            containerRegistry.RegisterForNavigation<Expenses, ExpensesViewModel>(ViewNames.ExpensesView);
        }
        
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
