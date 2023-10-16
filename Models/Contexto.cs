using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financas.WEBMVC.Models
{
    
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)  : base(options) { }

        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Ajuste> Ajustes { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        
    }
}
