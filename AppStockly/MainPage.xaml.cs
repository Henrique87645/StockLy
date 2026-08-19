namespace AppStockly
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Carregamento();
        }

        async void Carregamento()
        {
            await Task.Delay(1500);

            imgCarregar.Rotation = 0;
            await imgCarregar.RotateTo(360, 3000);
            imgCarregar.Rotation = 0;
            await imgCarregar.RotateTo(360, 3000);
            imgCarregar.Rotation = 0;
            await imgCarregar.RotateTo(360, 3000);
            imgCarregar.Rotation = 0;

            Application.Current.MainPage = new NavigationPage(new pgPrincipal());
        }
    }
}
