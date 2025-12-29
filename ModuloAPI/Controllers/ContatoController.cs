using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            // return Ok(contato);
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorId(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));

            // if (contato == null)
            //     return NotFound();

            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBd = _context.Contatos.Find(id);

            if (contatoBd == null)
                return NotFound();

            contatoBd.Nome = contato.Nome;
            contatoBd.Telefone = contato.Telefone;
            contatoBd.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBd);
            _context.SaveChanges();

            return Ok(contatoBd);
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarParcialmente(int id, Contato contato)
        {
            var contatoBd = _context.Contatos.Find(id);

            if (contatoBd == null)
                return NotFound();

            contatoBd.Nome = contato.Nome;
            contatoBd.Telefone = contato.Telefone;
            contatoBd.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBd);
            _context.SaveChanges();

            return Ok(contatoBd);
        }

        [HttpDelete("{id}")]
        public IActionResult Atualizar(int id)
        {
            var contatoBd = _context.Contatos.Find(id);

            if (contatoBd == null)
                return NotFound();

            _context.Contatos.Remove(contatoBd);
            _context.SaveChanges();

            return NoContent();
        }
    }
}