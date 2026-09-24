//using AppStockly.ViewModels;
using AppStockly.Models;
namespace AppStockly.Views;

public partial class pgVisuProduto : ContentPage
{
	public pgVisuProduto()
	{
		InitializeComponent();

        //BindingContext = ViewModel;
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgPrincipal());
    }
}