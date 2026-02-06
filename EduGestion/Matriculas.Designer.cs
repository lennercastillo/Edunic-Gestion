namespace EduGestion
{
    partial class Matriculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.BtnMatriculas = new FontAwesome.Sharp.IconButton();
            this.BtnCalificaciones = new FontAwesome.Sharp.IconButton();
            this.BtnRegistros = new FontAwesome.Sharp.IconButton();
            this.BtnCursos = new FontAwesome.Sharp.IconButton();
            this.BtnPagos = new FontAwesome.Sharp.IconButton();
            this.BtnProfesores = new FontAwesome.Sharp.IconButton();
            this.BtnEstudiantes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(299, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Administracion de matriculas";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(171, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 263);
            this.dataGridView1.TabIndex = 11;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 34;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(671, 118);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(117, 44);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.Text = "CANCELAR";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 34;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(548, 118);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(117, 44);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.Text = "ELIMINAR";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(421, 118);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(121, 44);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "AGREGAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.BtnInicio);
            this.panel1.Controls.Add(this.BtnMatriculas);
            this.panel1.Controls.Add(this.BtnCalificaciones);
            this.panel1.Controls.Add(this.BtnRegistros);
            this.panel1.Controls.Add(this.BtnCursos);
            this.panel1.Controls.Add(this.BtnPagos);
            this.panel1.Controls.Add(this.BtnProfesores);
            this.panel1.Controls.Add(this.BtnEstudiantes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 450);
            this.panel1.TabIndex = 18;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnInicio.IconColor = System.Drawing.Color.White;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, -1);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(137, 64);
            this.BtnInicio.TabIndex = 7;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInicio.UseVisualStyleBackColor = true;
            // 
            // BtnMatriculas
            // 
            this.BtnMatriculas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnMatriculas.FlatAppearance.BorderSize = 0;
            this.BtnMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMatriculas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMatriculas.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.BtnMatriculas.IconColor = System.Drawing.Color.White;
            this.BtnMatriculas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMatriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMatriculas.Location = new System.Drawing.Point(0, 63);
            this.BtnMatriculas.Name = "BtnMatriculas";
            this.BtnMatriculas.Size = new System.Drawing.Size(137, 51);
            this.BtnMatriculas.TabIndex = 6;
            this.BtnMatriculas.Text = "Matriculas";
            this.BtnMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMatriculas.UseVisualStyleBackColor = true;
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
            this.BtnCalificaciones.Location = new System.Drawing.Point(0, 114);
            this.BtnCalificaciones.Name = "BtnCalificaciones";
            this.BtnCalificaciones.Size = new System.Drawing.Size(137, 54);
            this.BtnCalificaciones.TabIndex = 5;
            this.BtnCalificaciones.Text = "Calificaciones ";
            this.BtnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalificaciones.UseVisualStyleBackColor = true;
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
            this.BtnRegistros.Location = new System.Drawing.Point(0, 168);
            this.BtnRegistros.Name = "BtnRegistros";
            this.BtnRegistros.Size = new System.Drawing.Size(137, 55);
            this.BtnRegistros.TabIndex = 4;
            this.BtnRegistros.Text = "Registros";
            this.BtnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistros.UseVisualStyleBackColor = true;
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
            this.BtnCursos.Location = new System.Drawing.Point(0, 223);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(137, 64);
            this.BtnCursos.TabIndex = 3;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCursos.UseVisualStyleBackColor = true;
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
            this.BtnPagos.Location = new System.Drawing.Point(0, 287);
            this.BtnPagos.Name = "BtnPagos";
            this.BtnPagos.Size = new System.Drawing.Size(137, 49);
            this.BtnPagos.TabIndex = 2;
            this.BtnPagos.Text = "Pagos";
            this.BtnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagos.UseVisualStyleBackColor = true;
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
            this.BtnProfesores.Location = new System.Drawing.Point(0, 336);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(137, 50);
            this.BtnProfesores.TabIndex = 1;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProfesores.UseVisualStyleBackColor = true;
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
            this.BtnEstudiantes.Location = new System.Drawing.Point(0, 386);
            this.BtnEstudiantes.Name = "BtnEstudiantes";
            this.BtnEstudiantes.Size = new System.Drawing.Size(137, 64);
            this.BtnEstudiantes.TabIndex = 0;
            this.BtnEstudiantes.Text = "Estudiantes";
            this.BtnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Matriculas";
            this.Text = "Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnMatriculas;
        private FontAwesome.Sharp.IconButton BtnCalificaciones;
        private FontAwesome.Sharp.IconButton BtnRegistros;
        private FontAwesome.Sharp.IconButton BtnCursos;
        private FontAwesome.Sharp.IconButton BtnPagos;
        private FontAwesome.Sharp.IconButton BtnProfesores;
        private FontAwesome.Sharp.IconButton BtnEstudiantes;
    }
}