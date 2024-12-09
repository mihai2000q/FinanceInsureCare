﻿using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Expense.ViewModels
{
    internal class ExpensesViewModel : BindableBase
    {
        private string _message = "Expenses View";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
