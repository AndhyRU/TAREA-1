namespace MiApiCuadrado.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
        public int CantidadMaterias { get; set; }
        public int Edad { get; set; }

    }
}