using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financas.WEBMVC.Models
{
    [Table("Movimentacoes")]
    public class Movimentacao
    {
        [Key]
        public string Id { get; set; }

        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }

        public Movimentacao(  DateTime data, string descricao, decimal valor, string tipo)
        {
            Data = data;
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Id = Guid.NewGuid().ToString();
        }
    }
}
