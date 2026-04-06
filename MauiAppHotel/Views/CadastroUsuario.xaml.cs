using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroUsuario : ContentPage
{
	public CadastroUsuario()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Usuario usuario = new Usuario();
			usuario.Nome = nome_usuario.Text;
			usuario.Email = email_usuario.Text;
			usuario.Senha = senha_usuario.Text;

			// Conferir se o email usado no cadastro já está sendo usado em algum outro cadastro

			// Linq
			bool retorno_consulta_email = App.lista_usuarios.Any(i => (i.Email == usuario.Email));


            if (retorno_consulta_email)
			{
                throw new Exception("Erro ao criar cadastro, tente novamente");
            }
			else
			{
				App.lista_usuarios.Add(usuario);
				await DisplayAlertAsync("Sucesso", "Usuário cadastrado com sucesso", "Ok");
				await Navigation.PushAsync(new Views.LoginUsuario());
			}

        }
		catch(Exception ex)
		{
			await DisplayAlertAsync("Ops", ex.Message, "Ok");
        }

    }
}