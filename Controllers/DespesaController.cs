using Financas.WEBMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financas.WEBMVC.Controllers
{
    public class DespesaController : Controller
    {
        private readonly FinançasContext _context;

        public DespesaController(FinançasContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/despesas")]
        public IActionResult GetDespesas()
        {
            // Obtém todas as despesas do banco de dados
            var despesas = _context.Despesa.ToList();

            // Retorna as despesas
            return Ok(despesas);
        }

        [HttpGet]
        [Route("api/despesas/{id}")]
        public IActionResult GetDespesa(string id)
        {
            // Obtém a despesa do banco de dados
            var despesa = _context.Despesa.FirstOrDefault(d => d.Id == id);

            // Retorna a despesa
            return Ok(despesa);
        }

        [HttpPost]
        [Route("api/despesas")]
        public IActionResult SalvarDespesa([FromBody] Despesa despesa)
        {
            // Salva a despesa no banco de dados
            _context.Despesa.Add(despesa);
            _context.SaveChanges();

            // Retorna o status 201
            return Ok();
        }

        [HttpDelete]
        [Route("api/despesas/{id}")]
        public IActionResult ExcluirDespesa(string id)
        {
            // Obtém a despesa do banco de dados
            var despesa = _context.Despesa.FirstOrDefault(d => d.Id == id);

            // Exclui a despesa do banco de dados
            _context.Despesa.Remove(despesa);
            _context.SaveChanges();

            // Retorna o status 204
            return NoContent();
        }
    }
}
