using MiApiCuadrado.WinForms.Models;
using MiApiCuadrado.WinForms.Services;

namespace MiApiCuadrado.WinForms
{
    public partial class FormEstudiantes : Form
    {
        private readonly EstudianteService _estudianteService;

        private List<Estudiante> _estudiantes =
            new List<Estudiante>();

        public FormEstudiantes(
            EstudianteService estudianteService)
        {
            InitializeComponent();

            _estudianteService = estudianteService;

            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("ID");
            cmbBuscarPor.Items.Add("Matrícula");

            cmbBuscarPor.SelectedIndex = 0;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvEstudiantes.SelectionChanged +=
                dgvEstudiantes_SelectionChanged;

            Shown += FormEstudiantes_Shown;
        }

        private async void FormEstudiantes_Shown(
            object? sender,
            EventArgs e)
        {
            await CargarEstudiantes();
        }

        private async Task CargarEstudiantes()
        {
            try
            {
                btnActualizar.Enabled = false;

                _estudiantes =
                    await _estudianteService
                        .ObtenerEstudiantes();

                MostrarEstudiantes(_estudiantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los estudiantes.\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        private void MostrarEstudiantes(
            List<Estudiante> estudiantes)
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private Estudiante? ObtenerEstudianteSeleccionado()
        {
            if (dgvEstudiantes.CurrentRow == null)
                return null;

            return dgvEstudiantes
                .CurrentRow
                .DataBoundItem as Estudiante;
        }

        private void dgvEstudiantes_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            var estudiante =
                ObtenerEstudianteSeleccionado();

            bool seleccionado =
                estudiante != null;

            btnEditar.Enabled = seleccionado;
            btnEliminar.Enabled = seleccionado;
        }

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                new FormEstudiante(
                    _estudianteService);

            if (formulario.ShowDialog(this)
                == DialogResult.OK)
            {
                _ = CargarEstudiantes();
            }
        }

        private void btnEditar_Click(
            object sender,
            EventArgs e)
        {
            var estudiante =
                ObtenerEstudianteSeleccionado();

            if (estudiante == null)
            {
                MessageBox.Show(
                    "Seleccione un estudiante.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var formulario =
                new FormEstudiante(
                    _estudianteService,
                    estudiante);

            if (formulario.ShowDialog(this)
                == DialogResult.OK)
            {
                _ = CargarEstudiantes();
            }
        }

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            var estudiante =
                ObtenerEstudianteSeleccionado();

            if (estudiante == null)
            {
                MessageBox.Show(
                    "Seleccione un estudiante.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmacion =
                MessageBox.Show(
                    $"¿Está seguro de eliminar al estudiante "
                    + $"{estudiante.Nombre} "
                    + $"{estudiante.Apellido}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                bool eliminado =
                    await _estudianteService
                        .EliminarEstudiante(
                            estudiante.Id);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Estudiante eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarEstudiantes();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el estudiante.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al eliminar.\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscar.Clear();

            await CargarEstudiantes();
        }

        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscar.Clear();

            cmbBuscarPor.SelectedIndex = 0;

            dgvEstudiantes.ClearSelection();

            await CargarEstudiantes();
        }

        private void btnBuscar_Click(
     object sender,
     EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarEstudiantes(_estudiantes);
                return;
            }

            // Buscar por ID
            if (cmbBuscarPor.SelectedItem?.ToString() == "ID")
            {
                if (!int.TryParse(texto, out int id))
                {
                    MessageBox.Show(
                        "Para buscar por ID debe escribir un número entero.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var resultado = _estudiantes
                    .Where(e => e.Id == id)
                    .ToList();

                MostrarEstudiantes(resultado);
            }
            // Buscar por Matrícula
            else
            {
                var resultado = _estudiantes
                    .Where(e =>
                        e.Matricula != null &&
                        e.Matricula.Equals(
                            texto,
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();

                MostrarEstudiantes(resultado);
            }
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}