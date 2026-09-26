using AppStockly.Models;
using AppStockly.Views;
namespace AppStockly;

public partial class pgPrincipal : ContentPage
{
    public pgPrincipal()
    {
        InitializeComponent();

    }

    private void btnCadProduto_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgCadProdutoV2());
    }

    private void btnListaProduto_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgListaProdutos());
    }
}