using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Data
{
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; }
}
}