using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Sidebar.ViewModels
{
    internal class SidebarViewModel : BindableBase
    {
        private string _message = "Sidebar View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}