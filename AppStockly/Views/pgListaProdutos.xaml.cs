using AppStockly.Models;
using AppStockly.ViewModels;

namespace AppStockly.Views
{
    public partial class pgListaProdutos : ContentPage
    {
        public pgListaProdutos()
        {
            InitializeComponent();

            BindingContext = new ListaProdutoViewModel();

        }
    }
}