using Microsoft.Maui.Controls;

namespace YourApp
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Regresar a la p�gina principal
            await Navigation.PopAsync();
        }
    }
}

