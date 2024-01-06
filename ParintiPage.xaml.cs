using Aplicatie.Models;
using Aplicatie.Data;

namespace Aplicatie;

public partial class ParintiPage : ContentPage
{
	public ParintiPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        parintiListView.ItemsSource = await App.Database.ObtinereParintiAsync();
    }

    private async void AdaugaParinte_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ParintePage(new Parinte()));
    }

    private async void Parinte_Selected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ParintePage((Parinte)e.SelectedItem));
        }
    }
}