namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}