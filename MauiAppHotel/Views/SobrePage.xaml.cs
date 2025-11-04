using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class SobrePage : ContentPage
    {
        public SobrePage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Retorna para a página anterior na pilha de navegação
            await Navigation.PopAsync();
        }
    }
}
