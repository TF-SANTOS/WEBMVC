using Financas.WEBMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financas.WEBMVC.Controllers
{
    [Route("api/receitas")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly FinançasContext _context;

        public ReceitaController(FinançasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetReceitas()
        {
            // Obtém todas as receitas do banco de dados
            var receitas = _context.Receitas.ToList();

            // Retorna as receitas
            return Ok(receitas);
        }

        [HttpGet("{id}")]
        public IActionResult GetReceita(string id)
        {
            // Obtém a receita do banco de dados
            var receita = _context.Receitas.FirstOrDefault(r => r.Id == id);

            // Se a receita não foi encontrada, retorna 404
            if (receita == null)
            {
                return NotFound();
            }

            // Retorna a receita
            return Ok(receita);
        }

        [HttpPost]
        public IActionResult SalvarReceita([FromBody] Receita receita)
        {
            // Salva a receita no banco de dados
            _context.Receitas.Add(receita);
            _context.SaveChanges();

            // Retorna o status 201
            return CreatedAtAction(nameof(GetReceita), new { id = receita.Id }, receita);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirReceita(string id)
        {
            // Obtém a receita do banco de dados
            var receita = _context.Receitas.FirstOrDefault(r => r.Id == id);

            // Se a receita não foi encontrada, retorna 404
            if (receita == null)
            {
                return NotFound();
            }

            // Exclui a receita do banco de dados
            _context.Receitas.Remove(receita);
            _context.SaveChanges();

            // Retorna o status 204
            return NoContent();
        }
    }
}

