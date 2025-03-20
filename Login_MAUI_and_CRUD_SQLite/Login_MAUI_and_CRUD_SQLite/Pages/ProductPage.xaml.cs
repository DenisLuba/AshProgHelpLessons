using Login_MAUI.ViewModels;

namespace Login_MAUI.Pages;

public partial class ProductPage : ContentPage
{
	public ProductPage(ProductPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}