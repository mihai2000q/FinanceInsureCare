using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Income.ViewModels
{
    internal class IncomeViewModel : BindableBase
    {
        private string _message = "Income View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}