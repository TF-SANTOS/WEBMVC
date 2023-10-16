using Financas.WEBMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Financas;
using System.Linq;

namespace Financas.WEBMVC.Controllers
{

    public class MovimentacaoController : Controller
    {
        private readonly FinancasContext _context;

        public MovimentacaoController(FinancasContext context)
        {
            _context = context;
            return;
        }

        [HttpGet]
        [Route("api/movimentacoes")]
        public IActionResult GetMovimentacoes()
        {
            // Obtém todas as movimentações do banco de dados
            var movimentacoes = _context.Movimentacoes.ToList();

            // Retorna as movimentações
            return Ok(movimentacoes);
        }

        [HttpGet]
        [Route("api/movimentacoes/{id}")]
        public IActionResult GetMovimentacao(string id)
        {
            // Obtém a movimentação do banco de dados
            var movimentacao = _context.Movimentacoes.FirstOrDefault(m => m.Id == id);

            // Retorna a movimentação
            return Ok(movimentacao);
        }

        [HttpPost]
        [Route("api/movimentacoes")]
        public IActionResult SalvarMovimentacao([FromBody] Movimentacao movimentacao)
        {
            // Salva a movimentação no banco de dados
            _context.Movimentacoes.Add(movimentacao);
            _context.SaveChanges();

            // Retorna o status 201
            return Ok();
        }

        [HttpDelete]
        [Route("api/movimentacoes/{id}")]
        public IActionResult ExcluirMovimentacao(string id)
        {
            // Obtém a movimentação do banco de dados
            var movimentacao = _context.Movimentacoes.FirstOrDefault(m => m.Id == id);

            // Exclui a movimentação do banco de dados
            _context.Movimentacoes.Remove(movimentacao);
            _context.SaveChanges();

            // Retorna o status 204
            return NoContent();
        }
    }
}