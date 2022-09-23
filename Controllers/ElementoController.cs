using System.Collections.Generic;
using System.Linq;
using Elementos_Quimicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elementos_Quimicos.Controllers
{
    [Elementos_QuimicosController]
    [Route("Elementos_Quimicos/elemento")]
    public class ElementoController : ControllerBase
    {
        private readonly DataContext _context;
        public ElementoController(DataContext context) =>
            _context = context;

        // Elementos_Quimicos/elemento/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Elementos.ToList());

        // /Elementos_Quimicos/elemento/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Elemento elemento)
        {Elemento
            _context.Elementos.Add(elemento);
            _context.SaveChanges();
            return Created("", elemento);
        }

        //  /Elementos_Quimicos/elemento/buscar/{id}
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] string id)
        {
            Elemento elemento = _context.Elementos.
                FirstOrDefault(f => f.ID.Equals(id));
            return elemento != null ? Ok(elemento) : NotFound();
        }

        //  /Elementos_Quimicos/elemento/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Elemento elemento = _context.Elementos.Find(id);
            if (funcionario != null)
            {
                _context.Elementos.Remove(elemento);
                _context.SaveChanges();
                return Ok(elemento);
            }
            return NotFound();
        }

        // /Elementos_Quimicos/elemento/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Elemento elemento)
        {
            try
            {
                _context.Elementos.Update(elemento);
                _context.SaveChanges();
                return Ok(elemento);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}