using Login_MAUI.Models;
using Login_MAUI.ViewModels;

namespace Login_MAUI.Pages;

public partial class AddProductPage : ContentPage
{
	#region Properties
	public ProductInfo ProductInfo { get; set; } 
	#endregion

	#region Constructor
	public AddProductPage(AddProductPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	} 
	#endregion
}