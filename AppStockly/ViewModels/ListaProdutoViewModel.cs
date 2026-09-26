using AppStockly.Models;
using System.Collections.Generic;

namespace AppStockly.ViewModels
{
    public class ListaProdutoViewModel : BaseNotifyViewModel
    {
        public List<Produto> Produtos { get; set; }

        public ListaProdutoViewModel()
        {
            Produtos = ProdutoSingleton.Instancia.Produtos;
        }

        public Command VoltarCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new pgPrincipal());
                });
            }
        }
    }
}