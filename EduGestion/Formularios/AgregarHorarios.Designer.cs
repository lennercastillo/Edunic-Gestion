namespace EduGestion.Formularios
{
    partial class AgregarHorarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxHorarios;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.Label labelAula;
        private System.Windows.Forms.ComboBox comboBoxAula;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.components = new System.ComponentModel.Container();
            this.groupBoxHorarios = new System.Windows.Forms.GroupBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.labelAula = new System.Windows.Forms.Label();
            this.comboBoxAula = new System.Windows.Forms.ComboBox();
            this.labelInicio = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFin = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHorarios
            // 
            this.groupBoxHorarios.Controls.Add(this.labelCurso);
            this.groupBoxHorarios.Controls.Add(this.comboBoxCurso);
            this.groupBoxHorarios.Controls.Add(this.labelProfesor);
            this.groupBoxHorarios.Controls.Add(this.comboBoxProfesor);
            this.groupBoxHorarios.Controls.Add(this.labelAula);
            this.groupBoxHorarios.Controls.Add(this.comboBoxAula);
            this.groupBoxHorarios.Controls.Add(this.labelInicio);
            this.groupBoxHorarios.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxHorarios.Controls.Add(this.labelFin);
            this.groupBoxHorarios.Controls.Add(this.dateTimePickerFin);
            this.groupBoxHorarios.Controls.Add(this.labelEstado);
            this.groupBoxHorarios.Controls.Add(this.comboBoxEstado);
            this.groupBoxHorarios.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHorarios.Name = "groupBoxHorarios";
            this.groupBoxHorarios.Size = new System.Drawing.Size(360, 240);
            this.groupBoxHorarios.TabIndex = 0;
            this.groupBoxHorarios.TabStop = false;
            this.groupBoxHorarios.Text = "Horarios";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(16, 28);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(40, 13);
            this.labelCurso.TabIndex = 0;
            this.labelCurso.Text = "Curso:";
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(120, 25);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(220, 21);
            this.comboBoxCurso.TabIndex = 1;
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Location = new System.Drawing.Point(16, 60);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(52, 13);
            this.labelProfesor.TabIndex = 2;
            this.labelProfesor.Text = "Profesor:";
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(120, 57);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(220, 21);
            this.comboBoxProfesor.TabIndex = 3;
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.Location = new System.Drawing.Point(16, 92);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(34, 13);
            this.labelAula.TabIndex = 4;
            this.labelAula.Text = "Aula:";
            // 
            // comboBoxAula
            // 
            this.comboBoxAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAula.FormattingEnabled = true;
            this.comboBoxAula.Location = new System.Drawing.Point(120, 89);
            this.comboBoxAula.Name = "comboBoxAula";
            this.comboBoxAula.Size = new System.Drawing.Size(220, 21);
            this.comboBoxAula.TabIndex = 5;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(16, 124);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(39, 13);
            this.labelInicio.TabIndex = 6;
            this.labelInicio.Text = "Inicio:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInicio.ShowUpDown = true;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(120, 120);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerInicio.TabIndex = 7;
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(16, 156);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(25, 13);
            this.labelFin.TabIndex = 8;
            this.labelFin.Text = "Fin:";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFin.ShowUpDown = true;
            this.dateTimePickerFin.Location = new System.Drawing.Point(120, 152);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFin.TabIndex = 9;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(16, 188);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 10;
            this.labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(120, 185);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(220, 21);
            this.comboBoxEstado.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(216, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarHorarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.groupBoxHorarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Horarios";
            this.groupBoxHorarios.ResumeLayout(false);
            this.groupBoxHorarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
