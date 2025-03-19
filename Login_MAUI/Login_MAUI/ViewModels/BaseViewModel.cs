using CommunityToolkit.Mvvm.ComponentModel;

namespace Login_MAUI.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy;
    [ObservableProperty]
    private string? _title;
}
