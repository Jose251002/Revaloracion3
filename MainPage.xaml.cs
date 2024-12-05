using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarSesionClicked(object sender, EventArgs e)
        {
            // Navegar a NewPage1
            await Navigation.PushAsync(new NewPage1());
        }

        private async void OnCrearCuentaClicked(object sender, EventArgs e)
        {
            // Navegar a Crear Cuenta (volver a MainPage, si es necesario)
            await Navigation.PushAsync(new MainPage());
        }
    }
}
