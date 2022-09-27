using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/family")]
    public class FamilyController : ControllerBase
    {
        private readonly DataContext _context;
        public FamilyController(DataContext context) =>
            _context = context;

        // GET: /api/family/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Families.ToList());

        // POST: /api/family/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Family family)
        {
            _context.Families.Add(family);
            _context.SaveChanges();
            return Created("", family);
        }

        // GET: /api/family/search/{id}
        [HttpGet]
        [Route("search/{id}")]
        public IActionResult Search([FromRoute] string id)
        {
            Family family = _context.Families.
                FirstOrDefault(f => f.Id.Equals(id));
            return family != null ? Ok(family) : NotFound();
        }

        // DELETE: /api/family/delete/{id}
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Family family = _context.Families.Find(id);
            if (family != null)
            {
                _context.Families.Remove(family);
                _context.SaveChanges();
                return Ok(family);
            }
            return NotFound();
        }

        // PATCH: /api/family/update
        [HttpPatch]
        [Route("update")]
        public IActionResult Update([FromBody] Family family)
        {
            try
            {
                _context.Families.Update(family);
                _context.SaveChanges();
                return Ok(family);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}