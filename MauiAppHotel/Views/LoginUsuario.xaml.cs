using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class LoginUsuario : ContentPage
{
	public LoginUsuario()
	{
		InitializeComponent();
	}
    private async void Button_Clicked_Entrar(object sender, EventArgs e)
    {
        try
        {
            //CadastroUsuario tela_cadastro_usuario = new();
            //await Navigation.PushAsync(tela_cadastro_usuario);

            // Dados inseridos pelo usuário na View
            Usuario usuario = new Usuario();
            usuario.Email = email_usuario.Text;
            usuario.Senha = senha_usuario.Text;

            // Linq
            bool retorno = App.lista_usuarios.Any(i => (i.Senha == usuario.Senha && i.Email == usuario.Email));

            if (retorno)
            {
                await DisplayAlertAsync("Aviso", "Logado com sucesso", "Ok");
                await SecureStorage.Default.SetAsync("nome_usuario", usuario.Email);
            }
            else
            {
                throw new Exception("E-mail ou senha inválidos");
            }

        }
        catch(ArgumentNullException ex)
        {
            await DisplayAlertAsync("Ops", "Você não preencheu o display alert direito", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "Ok");
        }
    }

    private async void Button_Clicked_Cadastrar(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Views.CadastroUsuario());
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "Ok");
        }
    }
}