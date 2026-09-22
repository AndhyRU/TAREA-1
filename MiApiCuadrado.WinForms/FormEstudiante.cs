using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MiApiCuadrado.WinForms.Models;
using MiApiCuadrado.WinForms.Services;


namespace MiApiCuadrado.WinForms
{
    public partial class FormEstudiante : Form
    {
        private readonly EstudianteService _estudianteService;
        private readonly Estudiante? _estudiante;

        public FormEstudiante(
            EstudianteService estudianteService,
            Estudiante? estudiante = null)
        {
            InitializeComponent();

            _estudianteService = estudianteService;
            _estudiante = estudiante;

            if (_estudiante != null)
            {
                Text = "Editar estudiante";

                txtNombre.Text = _estudiante.Nombre;
                txtApellido.Text = _estudiante.Apellido;
                txtMatricula.Text = _estudiante.Matricula;
                txtCarrera.Text = _estudiante.Carrera;
                txtMaterias.Text = _estudiante.CantidadMaterias.ToString();
                txtEdad.Text = _estudiante.Edad.ToString();
            }
            else
            {
                Text = "Agregar estudiante";
            }
        }

        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Debe escribir el nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show(
                    "Debe escribir el apellido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show(
                    "La matrícula debe ser un número válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatricula.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show(
                    "Debe escribir la carrera.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCarrera.Focus();
                return;
            }

            if (!int.TryParse(
                txtMaterias.Text,
                out int cantidad))
            {
                MessageBox.Show(
                    "La cantidad debe ser un número entero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaterias.Focus();
                return;
            }

            if (!int.TryParse(
               txtEdad.Text,
               out int edad))
            {
                MessageBox.Show(
                    "La cantidad debe ser un número entero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEdad.Focus();
                return;
            }

            var estudiante = new Estudiante
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Matricula = txtMatricula.Text.Trim(),
                Carrera = txtCarrera.Text.Trim(),
                CantidadMaterias = cantidad,
                Edad = edad,
            };

            bool resultado;

            if (_estudiante == null)
            {
                resultado =
                    await _estudianteService
                        .CrearEstudiante(estudiante);
            }
            else
            {
                resultado =
                    await _estudianteService
                        .ActualizarEstudiante(
                            _estudiante.Id,
                            estudiante);
            }

            if (resultado)
            {
                MessageBox.Show(
                    _estudiante == null
                        ? "Estudiante agregado correctamente."
                        : "Estudiante actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo guardar el estudiante.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
