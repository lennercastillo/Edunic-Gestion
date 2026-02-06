namespace EduGestion
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.btnMatriculas = new FontAwesome.Sharp.IconButton();
            this.BtnCalificaciones = new FontAwesome.Sharp.IconButton();
            this.BtnRegistros = new FontAwesome.Sharp.IconButton();
            this.BtnCursos = new FontAwesome.Sharp.IconButton();
            this.BtnPagos = new FontAwesome.Sharp.IconButton();
            this.BtnProfesores = new FontAwesome.Sharp.IconButton();
            this.BtnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "EDUNIC - GESTION";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelContenedor.Controls.Add(this.BtnInicio);
            this.panelContenedor.Controls.Add(this.btnMatriculas);
            this.panelContenedor.Controls.Add(this.BtnCalificaciones);
            this.panelContenedor.Controls.Add(this.BtnRegistros);
            this.panelContenedor.Controls.Add(this.BtnCursos);
            this.panelContenedor.Controls.Add(this.BtnPagos);
            this.panelContenedor.Controls.Add(this.BtnProfesores);
            this.panelContenedor.Controls.Add(this.BtnEstudiantes);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(136, 450);
            this.panelContenedor.TabIndex = 23;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnInicio.IconColor = System.Drawing.Color.White;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 0);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(136, 64);
            this.BtnInicio.TabIndex = 7;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInicio.UseVisualStyleBackColor = true;
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMatriculas.FlatAppearance.BorderSize = 0;
            this.btnMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMatriculas.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnMatriculas.IconColor = System.Drawing.Color.White;
            this.btnMatriculas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatriculas.Location = new System.Drawing.Point(0, 64);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Size = new System.Drawing.Size(136, 51);
            this.btnMatriculas.TabIndex = 6;
            this.btnMatriculas.Text = "Matriculas";
            this.btnMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatriculas.UseVisualStyleBackColor = true;
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // BtnCalificaciones
            // 
            this.BtnCalificaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCalificaciones.FlatAppearance.BorderSize = 0;
            this.BtnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalificaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCalificaciones.IconChar = FontAwesome.Sharp.IconChar.Award;
            this.BtnCalificaciones.IconColor = System.Drawing.Color.White;
            this.BtnCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalificaciones.Location = new System.Drawing.Point(0, 115);
            this.BtnCalificaciones.Name = "BtnCalificaciones";
            this.BtnCalificaciones.Size = new System.Drawing.Size(136, 54);
            this.BtnCalificaciones.TabIndex = 5;
            this.BtnCalificaciones.Text = "Calificaciones ";
            this.BtnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalificaciones.UseVisualStyleBackColor = true;
            this.BtnCalificaciones.Click += new System.EventHandler(this.BtnCalificaciones_Click);
            // 
            // BtnRegistros
            // 
            this.BtnRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRegistros.FlatAppearance.BorderSize = 0;
            this.BtnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistros.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.BtnRegistros.IconColor = System.Drawing.Color.White;
            this.BtnRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistros.Location = new System.Drawing.Point(0, 169);
            this.BtnRegistros.Name = "BtnRegistros";
            this.BtnRegistros.Size = new System.Drawing.Size(136, 55);
            this.BtnRegistros.TabIndex = 4;
            this.BtnRegistros.Text = "Registros";
            this.BtnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistros.UseVisualStyleBackColor = true;
            this.BtnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCursos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BtnCursos.IconColor = System.Drawing.Color.White;
            this.BtnCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 224);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(136, 64);
            this.BtnCursos.TabIndex = 3;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCursos.UseVisualStyleBackColor = true;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // BtnPagos
            // 
            this.BtnPagos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPagos.FlatAppearance.BorderSize = 0;
            this.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.BtnPagos.IconColor = System.Drawing.Color.White;
            this.BtnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagos.Location = new System.Drawing.Point(0, 288);
            this.BtnPagos.Name = "BtnPagos";
            this.BtnPagos.Size = new System.Drawing.Size(136, 49);
            this.BtnPagos.TabIndex = 2;
            this.BtnPagos.Text = "Pagos";
            this.BtnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagos.UseVisualStyleBackColor = true;
            this.BtnPagos.Click += new System.EventHandler(this.BtnPagos_Click);
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnProfesores.FlatAppearance.BorderSize = 0;
            this.BtnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProfesores.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.BtnProfesores.IconColor = System.Drawing.Color.White;
            this.BtnProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfesores.Location = new System.Drawing.Point(0, 337);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(136, 50);
            this.BtnProfesores.TabIndex = 1;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProfesores.UseVisualStyleBackColor = true;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            // 
            // BtnEstudiantes
            // 
            this.BtnEstudiantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEstudiantes.FlatAppearance.BorderSize = 0;
            this.BtnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnEstudiantes.IconColor = System.Drawing.Color.White;
            this.BtnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstudiantes.Location = new System.Drawing.Point(0, 387);
            this.BtnEstudiantes.Name = "BtnEstudiantes";
            this.BtnEstudiantes.Size = new System.Drawing.Size(136, 63);
            this.BtnEstudiantes.TabIndex = 0;
            this.BtnEstudiantes.Text = "Estudiantes";
            this.BtnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEstudiantes.UseVisualStyleBackColor = true;
            this.BtnEstudiantes.Click += new System.EventHandler(this.BtnEstudiantes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton btnMatriculas;
        private FontAwesome.Sharp.IconButton BtnCalificaciones;
        private FontAwesome.Sharp.IconButton BtnRegistros;
        private FontAwesome.Sharp.IconButton BtnCursos;
        private FontAwesome.Sharp.IconButton BtnPagos;
        private FontAwesome.Sharp.IconButton BtnProfesores;
        private FontAwesome.Sharp.IconButton BtnEstudiantes;
    }
}