using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        // Campo onde os dados estão guardados
        Quarto quarto_selecionado = new();

        // Propriedades para acessar os dados
        public Quarto QuartoSelecionado { 
            get => quarto_selecionado;
            set 
            { 
                if(value == null)
                {
                    throw new Exception("Selecione um quarto.");
                }

                quarto_selecionado = value;
            } 
        }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
                //return (DataCheckOut - DataCheckIn).Days;
            }

            //get => (DataCheckOut - DataCheckIn).Days;

        }
        public double ValorTotal {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double valor_total = (valor_adultos + valor_criancas) * Estadia;

                return valor_total;
            }
        }
        
    }
}
