using MiApiCuadrado.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace MiApiCuadrado.WinForms.Services
{
    public class EstudianteService
    {
        private readonly HttpClient _httpClient;

        public EstudianteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Estudiante>> ObtenerEstudiantes()
        {
            var estudiantes = await _httpClient
                .GetFromJsonAsync<List<Estudiante>>(
                    "api/ControladorEstudiantes");

            return estudiantes ?? new List<Estudiante>();
        }

        public async Task<bool> CrearEstudiante(Estudiante estudiante)
        {
            var response = await _httpClient
                .PostAsJsonAsync(
                    "api/ControladorEstudiantes",
                    estudiante);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarEstudiante(
            int id,
            Estudiante estudiante)
        {
            var response = await _httpClient
                .PutAsJsonAsync(
                    $"api/ControladorEstudiantes/{id}",
                    estudiante);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarEstudiante(int id)
        {
            var response = await _httpClient
                .DeleteAsync(
                    $"api/ControladorEstudiantes/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
