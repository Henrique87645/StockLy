using AppStockly.ViewModels;

namespace AppStockly.Views;

public partial class pgLoginV2 : ContentPage
{
	public pgLoginV2()
	{
		InitializeComponent();
        BindingContext = new CadLoginViewModel();
    }
}