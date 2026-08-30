using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;   
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorEstudiantes : ControllerBase
    {
        private readonly AppDbContext _context;

        public ControladorEstudiantes(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ControladorEstudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        // GET: api/ControladorEstudiantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetEstudiante(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }

            return estudiante;
        }   

    }

}          