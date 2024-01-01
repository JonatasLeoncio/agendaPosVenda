using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaPosVenda.Model
{
    public class Registro
    {
        public int Id { get; set; }
        public int Talao { get; set; }
        public string? Funcionario { get; set; }
        public int CodCliente { get; set; }
        public string? NomeCliente { get; set; }

        public string? Telefone { get; set; }

        public string? Status { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataAberta { get; set; }
        public DateTime? DataPrevEntrega { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataPosVenda { get; set; }
        public string? Observacao { get; set; }
        public Decimal? Valor { get; set; }

    }
}
