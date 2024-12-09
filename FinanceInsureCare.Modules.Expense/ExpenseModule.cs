using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Expense.ViewModels;
using FinanceInsureCare.Modules.Expense.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.Modules.Expense
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class ExpenseModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Expenses, ExpensesViewModel>(ViewNames.ExpensesView);
        }
    }
}
