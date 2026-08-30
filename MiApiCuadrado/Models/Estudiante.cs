namespace MiApiCuadrado.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Matricula { get; set; }
        public string Carrera { get; set; }
        public int CantidadMaterias { get; set; }
        public int Edad { get; set; }


    }
}