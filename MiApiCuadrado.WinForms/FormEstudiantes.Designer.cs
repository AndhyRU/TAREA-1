using MiApiCuadrado.WinForms.Models;
using MiApiCuadrado.WinForms.Services;


namespace MiApiCuadrado.WinForms
{
    partial class FormEstudiantes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblError = new Label();
            cmbBuscarPor = new ComboBox();
            lblBusqueda = new Label();
            pnlAcciones = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvEstudiantes = new DataGridView();
            pnlBusqueda.SuspendLayout();
            pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblError);
            pnlBusqueda.Controls.Add(cmbBuscarPor);
            pnlBusqueda.Controls.Add(lblBusqueda);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1084, 55);
            pnlBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(275, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(68, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(3, 15);
            lblError.Name = "lblError";
            lblError.Size = new Size(59, 15);
            lblError.TabIndex = 2;
            lblError.Text = "Busqueda";
            // 
            // cmbBuscarPor
            // 
            cmbBuscarPor.FormattingEnabled = true;
            cmbBuscarPor.Items.AddRange(new object[] { "ID", "Matrícula" });
            cmbBuscarPor.Location = new Point(951, 15);
            cmbBuscarPor.Name = "cmbBuscarPor";
            cmbBuscarPor.Size = new Size(121, 23);
            cmbBuscarPor.TabIndex = 1;
           
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(886, 18);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(69, 15);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "Buscar Por: ";
            // 
            // pnlAcciones
            // 
            pnlAcciones.Controls.Add(btnEliminar);
            pnlAcciones.Controls.Add(btnActualizar);
            pnlAcciones.Controls.Add(btnLimpiar);
            pnlAcciones.Controls.Add(btnEditar);
            pnlAcciones.Controls.Add(btnAgregar);
            pnlAcciones.Dock = DockStyle.Top;
            pnlAcciones.Location = new Point(0, 55);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(1084, 55);
            pnlAcciones.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(589, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(435, 0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(275, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(110, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(0, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.Location = new Point(0, 110);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(1084, 501);
            dgvEstudiantes.TabIndex = 1;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
            // 
            // FormEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(dgvEstudiantes);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlBusqueda);
            Name = "FormEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Estudiantes";
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBusqueda;
        private Panel pnlAcciones;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label lblBusqueda;
        private ComboBox cmbBuscarPor;
        private TextBox txtBuscar;
        private Label lblError;
        private Button btnBuscar;
        private DataGridView dgvEstudiantes;
    }
}
