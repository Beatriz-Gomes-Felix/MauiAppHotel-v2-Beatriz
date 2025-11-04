using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ConfiguracoesPage : ContentPage
    {
        public ConfiguracoesPage()
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
