using System.Diagnostics.CodeAnalysis;
using FinanceInsureCare.Core;
using FinanceInsureCare.Core.Constants;
using FinanceInsureCare.Modules.Invoice.ViewModels;
using FinanceInsureCare.Modules.Invoice.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Invoice
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class InvoiceModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<Invoices, InvoicesViewModel>();
            containerRegistry.RegisterForNavigation<Invoices, InvoicesViewModel>(ViewNames.InvoicesView);
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}