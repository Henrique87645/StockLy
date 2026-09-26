using Microsoft.Extensions.DependencyInjection;
using AppStockly.Views;
using AppStockly.Models;

namespace AppStockly
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new pgPrincipal());

            window.Height = 750; //Altura
            window.Width = 500;  //Largura

            return window;
        }
    }
}   