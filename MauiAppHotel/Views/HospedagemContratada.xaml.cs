namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{

    bool usuario_logado = false;


	public HospedagemContratada()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    protected override async void OnAppearing()
    {
        string? email_usuario = await SecureStorage.Default.GetAsync("nome_usuario");

        if (email_usuario != null)
            usuario_logado = true;
    }



    private async void Button_Clicked_Avancar(object sender, EventArgs e)
    {
        try
        {
            if (!usuario_logado)
            {
                await Navigation.PushAsync(new Views.LoginUsuario());
            }
            else
            {
                await DisplayAlertAsync("Oba!", "Você já está logado! Hora de pagar!", "Ok");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "Ok");
        }
    }
}