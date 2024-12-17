﻿using System.Windows;
using FinanceInsureCare.Modules.Client;
using FinanceInsureCare.Modules.Dashboard;
using FinanceInsureCare.Modules.Expense;
using FinanceInsureCare.Modules.Income;
using FinanceInsureCare.Modules.Invoice;
using FinanceInsureCare.Modules.Sidebar;
using FinanceInsureCare.Modules.Topbar;
using FinanceInsureCare.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace FinanceInsureCare.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            DotNetEnv.Env.TraversePath().Load();
        }
        
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ClientModule>();
            moduleCatalog.AddModule<DashboardModule>();
            moduleCatalog.AddModule<ExpenseModule>();
            moduleCatalog.AddModule<IncomeModule>();
            moduleCatalog.AddModule<InvoiceModule>();
            moduleCatalog.AddModule<SidebarModule>();
            moduleCatalog.AddModule<TopbarModule>();
        }
    }
}
