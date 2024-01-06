using Aplicatie.Data;
using Aplicatie.Models;
namespace Aplicatie;

public partial class ParintePage : ContentPage
{
    private Parinte _parinte;

    public ParintePage(Parinte parinte)
    {
        InitializeComponent();
        _parinte = parinte;

        if (_parinte != null)
        {
            NumeEntry.Text = _parinte.Nume;
            PrenumeEntry.Text = _parinte.Prenume;
            NumarTelefonEntry.Text = _parinte.NumarTelefon;
        }
    }

    private async void Salveaza_Clicked(object sender, EventArgs e)
    {
        _parinte.Nume = NumeEntry.Text;
        _parinte.Prenume = PrenumeEntry.Text;
        _parinte.NumarTelefon = NumarTelefonEntry.Text;

        await App.Database.SalvareParinteAsync(_parinte);
        await Navigation.PopAsync();
    }

    private async void Sterge_Clicked(object sender, EventArgs e)
    {
        await App.Database.StergereParinteAsync(_parinte);
        await Navigation.PopAsync();
    }
}
