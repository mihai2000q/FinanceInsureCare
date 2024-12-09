using System.Windows;
using FinanceInsureCare.Modules.Client;
using FinanceInsureCare.Modules.Expense;
using FinanceInsureCare.UI.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ClientModule>();
            moduleCatalog.AddModule<ExpenseModule>();
        }
    }
}
