namespace MiApiCuadrado.WinForms
{
    partial class FormEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblMatricula = new Label();
            Materias = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMatricula = new TextBox();
            txtMaterias = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 55);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido :";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(12, 89);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(63, 15);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matricula :";
            // 
            // Materias
            // 
            Materias.AutoSize = true;
            Materias.Location = new Point(12, 162);
            Materias.Name = "Materias";
            Materias.Size = new Size(129, 15);
            Materias.TabIndex = 3;
            Materias.Text = "Materias Selecionadas :";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 191);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(180, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(180, 47);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(180, 89);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 7;
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(180, 154);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(100, 23);
            txtMaterias.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(180, 191);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(69, 26);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(13, 127);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(51, 15);
            lblCarrera.TabIndex = 12;
            lblCarrera.Text = "Carrera :";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(180, 118);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 13;
            // 
            // FormEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 294);
            Controls.Add(txtCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtMaterias);
            Controls.Add(txtMatricula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(Materias);
            Controls.Add(lblMatricula);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblMatricula;
        private Label Materias;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMatricula;
        private TextBox txtMaterias;
        private TextBox txtEdad;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCarrera;
        private TextBox txtCarrera;
    }
}