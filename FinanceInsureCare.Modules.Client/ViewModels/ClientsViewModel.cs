using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Client.ViewModels
{
    internal class ClientsViewModel : BindableBase
    {
        private string _message = "Clients View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
