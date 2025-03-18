using MVVM_MAUI.ViewModels;

namespace MVVM_MAUI.Views;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
		InitializeComponent();

		BindingContext = new BMICalculatorPageViewModel();
	}
}