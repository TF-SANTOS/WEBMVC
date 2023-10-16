using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financas.WEBMVC.Models
{
    [Table("Ajustes")]
    public class Ajuste : Movimentacao
    {
        [Required]
        [StringLength(35)]
        public string Categoria { get; set; }
        [Required]
        [StringLength(35)]
        public string Conta { get; set; }

        public Ajuste(DateTime data, string descricao, decimal valor, string categoria, string conta)
            : base(data, descricao, valor, "ajuste")
        {
            Categoria = categoria;
            Conta = conta;
        }
    }
}
