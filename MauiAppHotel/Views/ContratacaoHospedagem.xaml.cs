using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	List<Quarto> lista_quartos = new()
	{
		new Quarto()
		{
			Descricao = "Suíte Super Luxo",
            ValorDiariaAulto = 110.0,
			ValorDiariaCrianca = 55
		},
		new Quarto()
		{
			Descricao= "Suíte Luxo",
			ValorDiariaAulto = 80.0,
			ValorDiariaCrianca = 40.0
        },
        new Quarto()
        {
            Descricao= "Suíte Simples",
            ValorDiariaAulto = 25.0,
            ValorDiariaCrianca = 12.5
        },
    };

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        // Abastecendo o picker com a lista de quartos
        pck_quarto.ItemsSource = lista_quartos;

        // Validando a data mínima e máxima de checkin
        dtpck_checkin.MinimumDate = DateTime.Now;
        //dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(2);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(2);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = (DatePicker)sender;

        DateTime data_selecionada = elemento.Date.Value;

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(2);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}