using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financas.WEBMVC.Models
{
    [Table("Despesas")]
    public class Despesa : Movimentacao
    {
        [Required]
        [StringLength(35)]
        public string Categoria { get; set; }

        public Despesa(DateTime data, string descricao, decimal valor, string categoria)
            : base(data, descricao, valor, "despesa")
        {
            Categoria = categoria;
        }
    }
}
