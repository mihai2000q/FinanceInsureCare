using System.Diagnostics.CodeAnalysis;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Invoice.ViewModels
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class InvoicesViewModel : BindableBase
    {
        private string _message = "Invoices View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}