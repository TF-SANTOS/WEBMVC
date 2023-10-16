using Financas.WEBMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financas.WEBMVC.Controllers
{
    public class AjusteController : Controller
    {
        
            private readonly FinançasContext _context;

        public AjusteController(FinançasContext context)
            {
                _context = context;
            }

            [HttpGet]
            [Route("api/ajustes")]
            public IActionResult GetAjustes()
            {
            // Obtém todos os ajustes do banco de dados
            var ajustes = _context.Ajuste.ToList();

                // Retorna os ajustes
                return Ok(ajustes);
            }

            [HttpGet]
            [Route("api/ajustes/{id}")]
            public IActionResult GetAjuste(string id)
            {
            // Obtém o ajuste do banco de dados
            var ajuste = _context.Ajuste.FirstOrDefault(a => a.Id == id);

                // Retorna o ajuste
                return Ok(ajuste);
            }

            [HttpPost]
            [Route("api/ajustes")]
            public IActionResult SalvarAjuste([FromBody] Ajuste ajuste)
            {
                // Salva o ajuste no banco de dados
                _context.Ajuste.Add(ajuste);
                _context.SaveChanges();

                // Retorna o status 201
                return Ok();
            }

            [HttpDelete]
            [Route("api/ajustes/{id}")]
            public IActionResult ExcluirAjuste(string id)
            {
                // Obtém o ajuste do banco de dados
                var ajuste = _context.Ajuste.FirstOrDefault(a => a.Id == id);

                // Exclui o ajuste do banco de dados
                _context.Ajuste.Remove(ajuste);
                _context.SaveChanges();

                // Retorna o status 204
                return NoContent();
            }
        }
    }

