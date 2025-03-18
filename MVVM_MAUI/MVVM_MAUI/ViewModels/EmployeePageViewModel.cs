using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_MAUI.ViewModels;

public partial class EmployeePageViewModel : ObservableObject
{
    [ObservableProperty]
    public string _employeeName;

    [RelayCommand]
    public void Save()
    {

    }
}
