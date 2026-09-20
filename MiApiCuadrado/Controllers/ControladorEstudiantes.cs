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
            var estudiante = await connection.QuerySingleOrDefaultAsync<Estudiante>(sql, new { Id = id });

            if (estudiante == null)
            {
                return NotFound();
            }

            return Ok(estudiante);
        }

        [HttpPost]
        public async Task<ActionResult<Estudiante>> CrearEstudiante(Estudiante estudiante)
        {
            using var connections = _context.CreateConnection();
            var sql = @"

              INSERT INTO Estudiantes
                (
                    Nombre,
                    Apellido,
                    Matricula,
                    Carrera,
                    CantidadMaterias,
                    Edad
                )
                VALUES
                (
                    @Nombre,
                    @Apellido,
                    @Matricula,
                    @Carrera,
                    @CantidadMaterias,
                    @Edad
                );

                SELECT CAST(SCOPE_IDENTITY() AS INT);    
             ";

            var id = await connections.ExecuteScalarAsync<int>(sql, estudiante);
            estudiante.Id = id;

            return CreatedAtAction(
                nameof(GetEstudiante),
                new { id = estudiante.Id },
                estudiante
            );



        }

        [HttpPut ("{id}")]
        public async Task<IActionResult> ActualizarEstudiante ( int id, Estudiante estudiante)
        {
            using var connection = _context.CreateConnection();
            var sqlBuscar = @"
                SELECT Id
                FROM Estudiantes
                WHERE Id = @Id";

            var existe = await connection.QuerySingleOrDefaultAsync<int?>(
                sqlBuscar,
                new { Id = id }
            );

            if (existe == null)
            {
                return NotFound(new
                {
                    mensaje = "Estudiante no encontrado."
                });
            }

            var sqlActualizar = @"
                UPDATE Estudiantes
                SET Nombre = @Nombre,
                    Apellido = @Apellido,
                    Matricula = @Matricula,
                    Carrera = @Carrera,
                    CantidadMaterias = @CantidadMaterias,
                    Edad = @Edad
                WHERE Id = @Id";

            estudiante.Id = id;

            await connection.ExecuteAsync(
                sqlActualizar,
                estudiante
            );

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarEstudiante(int id)
        {
            using var connection = _context.CreateConnection();

            var sql = @"
                DELETE FROM Estudiantes
                WHERE Id = @Id";

            var filasAfectadas = await connection.ExecuteAsync(
                sql,
                new { Id = id }
            );

            if (filasAfectadas == 0)
            {
                return NotFound(new
                {
                    mensaje = "Estudiante no encontrado."
                });
            }

            return NoContent();
        }


    }

}          