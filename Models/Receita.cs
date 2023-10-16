using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financas.WEBMVC.Models
{
    [Table("Receitas")]
    public class Receita : Movimentacao
    {
        [Required]
        [StringLength(35)]
        public string Categoria { get; set; }

        public Receita(DateTime data, string descricao, decimal valor, string categoria)
            : base(data, descricao, valor, "receita")
        {
            Categoria = categoria;
        }
    }
}
