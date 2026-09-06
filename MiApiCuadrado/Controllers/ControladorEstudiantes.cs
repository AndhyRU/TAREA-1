using Microsoft.AspNetCore.Mvc;
using Dapper;
using MiApiCuadrado.Data;   
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorEstudiantes : ControllerBase
    {
        private readonly DapperContext _context;

        public ControladorEstudiantes(DapperContext context)
        {
            _context = context;
        }

        // GET: api/ControladorEstudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiantes()
        {
            using var connection = _context.CreateConnection();

            var sql = "SELECT * FROM Estudiantes";

            var estudiantes = await connection.QueryAsync<Estudiante>(sql);

            return Ok(estudiantes);
        }

        // GET: api/ControladorEstudiantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetEstudiante(int id)
        {
            using var connection = _context.CreateConnection();

            var sql = "SELECT * FROM Estudiantes WHERE Id = @Id";
            var estudiante = await connection.QuerySingleAsync<Estudiante>(sql, new { Id = id });

            if (estudiante == null)
            {
                return NotFound();
            }

            return Ok(estudiante);
        }   

    }

}          