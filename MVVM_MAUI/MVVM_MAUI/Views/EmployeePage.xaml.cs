using MVVM_MAUI.ViewModels;

namespace MVVM_MAUI.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();

		BindingContext = new EmployeePageViewModel();
	}
}