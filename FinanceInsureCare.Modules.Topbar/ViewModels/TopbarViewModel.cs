using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Topbar.ViewModels
{
    internal class TopbarViewModel : BindableBase
    {
        private string _message = "Topbar View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}