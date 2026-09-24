using AppStockly.Models;
using AppStockly.Views;
namespace AppStockly;

public partial class pgPrincipal : ContentPage
{
	public pgPrincipal()
	{
		InitializeComponent();

        Shell.SetNavBarIsVisible(this, false);

        var pointer1 = new PointerGestureRecognizer();
        var pointer2 = new PointerGestureRecognizer();

        pointer1.PointerEntered += GridProduto1_PointerEntered;
        pointer1.PointerExited += GridProduto1_PointerExited;
        gridProduto1.GestureRecognizers.Add(pointer1);

        pointer2.PointerEntered += GridProduto2_PointerEntered;
        pointer2.PointerExited += GridProduto2_PointerExited;
        gridProduto2.GestureRecognizers.Add(pointer2);
    }

    private async void GridProduto1_PointerEntered(object? sender, PointerEventArgs e)
    {
        await gridProduto1.ScaleTo(1.05, 200);
    }

    private async void GridProduto1_PointerExited(object? sender, PointerEventArgs e)
    {
        await gridProduto1.ScaleTo(1.0, 200);
    }

    private async void GridProduto2_PointerEntered(object? sender, PointerEventArgs e)
    {
        await gridProduto2.ScaleTo(1.05, 200);
    }

    private async void GridProduto2_PointerExited(object? sender, PointerEventArgs e)
    {
        await gridProduto2.ScaleTo(1.0, 200);
    }
    private async void btnCadastrar_Pressed(object sender, EventArgs e)
    {
        await ((Button)sender).ScaleTo(1.08, 100);
    }

    private async void btnCadastrar_Released(object sender, EventArgs e)
    {
        await ((Button)sender).ScaleTo(1.0, 100);
    }
    
    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgCadProdutoV2());
    }

    private void btnVisualizar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgVisuProduto());
    }
}