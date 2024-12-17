using System.Diagnostics.CodeAnalysis;
using Prism.Mvvm;

namespace FinanceInsureCare.Modules.Dashboard.ViewModels;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
internal class DashboardViewModel : BindableBase
{
    private string _message = "Dashboard View";

    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value);
    }
}