using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Client.ViewModels
{
    internal class ClientsViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ClientsViewModel()
        {
            Message = "Clients View";
        }
    }
}
