using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Expense.ViewModels
{
    internal class ExpensesViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ExpensesViewModel()
        {
            Message = "Expenses View";
        }
    }
}
