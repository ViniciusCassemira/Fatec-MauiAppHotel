namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public string Descricao { get; set; } = String.Empty;
        public double ValorDiariaAulto { get; set; }
        public double ValorDiariaCrianca { get; set; }

        public string NomeComPreco
        {
            get
            {
                return string.Format($"{Descricao} - Adultos {ValorDiariaAulto:c} Crianças {ValorDiariaCrianca:c}");
            }
        }
    }
}