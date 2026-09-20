using System.Net.Http.Json;
using MiApiCuadrado.Blazor.Models;


namespace MiApiCuadrado.Blazor.Services
{
    public class EstudianteService
    {
        private readonly HttpClient _http;

        public EstudianteService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Estudiante>> ObtenerEstudiantes()
        {
            return await _http.GetFromJsonAsync<List<Estudiante>>(
                "api/ControladorEstudiantes"
            ) ?? new List<Estudiante>();
        }

        public async Task<Estudiante?> ObtenerEstudiante(int id)
        {
            return await _http.GetFromJsonAsync<Estudiante>(
                $"api/ControladorEstudiantes/{id}"
            );
        }

        public async Task<Estudiante?> CrearEstudiante(Estudiante estudiante)
        {
            var response = await _http.PostAsJsonAsync(
                "api/ControladorEstudiantes",
                estudiante
            );

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadFromJsonAsync<Estudiante>();
        }

        public async Task<bool> ActualizarEstudiante(
            int id,
            Estudiante estudiante)
        {
            var response = await _http.PutAsJsonAsync(
                $"api/ControladorEstudiantes/{id}",
                estudiante
            );

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarEstudiante(int id)
        {
            var response = await _http.DeleteAsync(
                $"api/ControladorEstudiantes/{id}"
            );

            return response.IsSuccessStatusCode;
        }
    }
}
