using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduGestion
{
    /// <summary>
    /// Clase estática con estilos modernos para todos los formularios de EduGestión.
    /// Uso: llama a UIHelper.AplicarEstiloFormulario(this) en el Form_Load de cada form.
    /// </summary>
    public static class UIHelper
    {
        // ==========================================`===
        //  PALETA DE COLORES
        // =============================================
        public static readonly Color ColorPrimario = Color.FromArgb(26, 42, 94);     // Azul oscuro menú
        public static readonly Color ColorPrimarioHover = Color.FromArgb(36, 56, 120);    // Hover botón primario
        public static readonly Color ColorAcento = Color.FromArgb(127, 159, 232);  // Azul claro acento
        public static readonly Color ColorFondo = Color.FromArgb(245, 246, 250);  // Gris claro fondo
        public static readonly Color ColorBlanco = Color.White;
        public static readonly Color ColorBorde = Color.FromArgb(230, 230, 240);  // Borde suave
        public static readonly Color ColorTextoMuted = Color.FromArgb(136, 136, 150);  // Texto secundario

        // Botón peligro (Eliminar)
        public static readonly Color ColorPeligroFondo = Color.FromArgb(252, 235, 235);
        public static readonly Color ColorPeligroBorde = Color.FromArgb(226, 75, 74);
        public static readonly Color ColorPeligroTexto = Color.FromArgb(153, 27, 27);

        // Botón advertencia (Actualizar)
        public static readonly Color ColorWarningFondo = Color.FromArgb(255, 247, 230);
        public static readonly Color ColorWarningBorde = Color.FromArgb(252, 211, 77);
        public static readonly Color ColorWarningTexto = Color.FromArgb(180, 83, 9);

        // DataGridView
        public static readonly Color ColorGridHeader = Color.FromArgb(249, 249, 253);
        public static readonly Color ColorGridFilaAlt = Color.FromArgb(250, 250, 254);
        public static readonly Color ColorGridSelFondo = Color.FromArgb(238, 240, 255);
        public static readonly Color ColorGridSelTexto = Color.FromArgb(26, 42, 94);
        public static readonly Color ColorGridBorde = Color.FromArgb(235, 235, 245);

        // Fuentes
        public static readonly Font FuenteBase = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font FuenteSmall = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        public static readonly Font FuenteTitulo = new Font("Segoe UI", 16f, FontStyle.Regular);
        public static readonly Font FuenteSubtitulo = new Font("Segoe UI", 11f, FontStyle.Regular);
        public static readonly Font FuenteMenu = new Font("Segoe UI", 10f, FontStyle.Regular);
        public static readonly Font FuenteHeader = new Font("Segoe UI", 8.5f, FontStyle.Bold);


        // =============================================
        //  MÉTODO PRINCIPAL — llama esto en Form_Load
        // =============================================

        /// <summary>
        /// Aplica el estilo base al formulario completo.
        /// Recorre todos los controles y aplica el estilo según su tipo.
        /// </summary>
        public static void AplicarEstiloFormulario(Form form)
        {
            form.BackColor = ColorFondo;
            form.Font = FuenteBase;

            foreach (Control ctrl in ObtenerTodosLosControles(form))
            {
                if (ctrl is Button btn) EstiloBoton(btn);
                else if (ctrl is DataGridView dgv) EstiloDataGridView(dgv);
                else if (ctrl is TextBox txt) EstiloTextBox(txt);
                else if (ctrl is ComboBox cmb) EstiloComboBox(cmb);
                else if (ctrl is Label lbl) EstiloLabel(lbl);
                else if (ctrl is Panel panel) EstiloPanel(panel);
                else if (ctrl is GroupBox grp) EstiloGroupBox(grp);
            }
        }


        // =============================================
        //  BOTONES
        // =============================================

        /// <summary>
        /// Estilo base para todos los botones.
        /// Detecta el nombre para aplicar color semántico automáticamente.
        /// </summary>
        public static void EstiloBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FuenteBase;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 6, 10, 6);

            string nombre = btn.Name.ToLower();

            if (nombre.Contains("agregar") || nombre.Contains("guardar") || nombre.Contains("nuevo"))
            {
                EstiloBotonPrimario(btn);
            }
            else if (nombre.Contains("eliminar") || nombre.Contains("borrar") || nombre.Contains("delete"))
            {
                EstiloBotonPeligro(btn);
            }
            else if (nombre.Contains("actualizar") || nombre.Contains("editar") || nombre.Contains("update"))
            {
                EstiloBotonAdvertencia(btn);
            }
            else if (nombre.Contains("cancelar") || nombre.Contains("cerrar") || nombre.Contains("salir"))
            {
                EstiloBotonGhost(btn);
            }
            else
            {
                // Estilo ghost por defecto
                EstiloBotonGhost(btn);
            }
        }

        public static void EstiloBotonPrimario(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ColorPrimarioHover;
            btn.BackColor = ColorPrimario;
            btn.ForeColor = Color.White;
            btn.Font = FuenteBase;
            btn.Cursor = Cursors.Hand;
        }

        public static void EstiloBotonPeligro(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = ColorPeligroBorde;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 220, 220);
            btn.BackColor = ColorPeligroFondo;
            btn.ForeColor = ColorPeligroTexto;
            btn.Font = FuenteBase;
            btn.Cursor = Cursors.Hand;
        }

        public static void EstiloBotonAdvertencia(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = ColorWarningBorde;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 240, 200);
            btn.BackColor = ColorWarningFondo;
            btn.ForeColor = ColorWarningTexto;
            btn.Font = FuenteBase;
            btn.Cursor = Cursors.Hand;
        }

        public static void EstiloBotonGhost(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = ColorBorde;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 248);
            btn.BackColor = ColorBlanco;
            btn.ForeColor = Color.FromArgb(85, 85, 95);
            btn.Font = FuenteBase;
            btn.Cursor = Cursors.Hand;
        }


        // =============================================
        //  MENÚ LATERAL
        // =============================================

        /// <summary>
        /// Aplica el estilo al panel del menú lateral.
        /// </summary>
        public static void EstiloMenuLateral(Panel panel)
        {
            panel.BackColor = ColorPrimario;

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is Button btn)
                    EstiloBotonMenu(btn);
            }
        }

        /// <summary>
        /// Estilo para botones dentro del menú lateral.
        /// </summary>
        public static void EstiloBotonMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(180, 200, 240);
            btn.Font = FuenteMenu;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(14, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.Dock = DockStyle.Top;
            btn.Height = 46;
        }

        /// <summary>
        /// Marca un botón del menú como activo (ítem seleccionado).
        /// </summary>
        public static void MarcarMenuActivo(Button btn)
        {
            btn.BackColor = Color.FromArgb(50, 255, 255, 255);
            btn.ForeColor = Color.White;
        }

        /// <summary>
        /// Desmarca un botón del menú (vuelve al estado normal).
        /// </summary>
        public static void DesmarcarMenu(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(180, 200, 240);
        }


        // =============================================
        //  DATAGRIDVIEW
        // =============================================

        public static void EstiloDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.GridColor = ColorGridBorde;
            dgv.BackgroundColor = ColorBlanco;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowTemplate.Height = 38;

            // Celda por defecto
            dgv.DefaultCellStyle.Font = FuenteBase;
            dgv.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            dgv.DefaultCellStyle.BackColor = ColorBlanco;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51);
            dgv.DefaultCellStyle.SelectionBackColor = ColorGridSelFondo;
            dgv.DefaultCellStyle.SelectionForeColor = ColorGridSelTexto;

            // Encabezado
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorGridHeader;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTextoMuted;
            dgv.ColumnHeadersDefaultCellStyle.Font = FuenteHeader;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorGridHeader;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorTextoMuted;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Filas alternadas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorGridFilaAlt;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorGridSelFondo;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = ColorGridSelTexto;
        }


        // =============================================
        //  TEXTBOX
        // =============================================

        public static void EstiloTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = ColorBlanco;
            txt.ForeColor = Color.FromArgb(26, 21, 53);
            txt.Font = FuenteBase;
            txt.Padding = new Padding(4);
        }


        // =============================================
        //  COMBOBOX
        // =============================================

        public static void EstiloComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.BackColor = ColorBlanco;
            cmb.ForeColor = Color.FromArgb(26, 21, 53);
            cmb.Font = FuenteBase;
        }


        // =============================================
        //  LABEL
        // =============================================

        public static void EstiloLabel(Label lbl)
        {
            lbl.Font = FuenteBase;

            // Detecta si es título por su nombre
            string nombre = lbl.Name.ToLower();
            if (nombre.Contains("titulo") || nombre.Contains("title"))
            {
                lbl.Font = FuenteTitulo;
                lbl.ForeColor = ColorPrimario;
            }
            else if (nombre.Contains("subtitulo") || nombre.Contains("subtitle"))
            {
                lbl.Font = FuenteSubtitulo;
                lbl.ForeColor = ColorTextoMuted;
            }
        }


        // =============================================
        //  PANEL
        // =============================================

        public static void EstiloPanel(Panel panel)
        {
            string nombre = panel.Name.ToLower();

            if (nombre.Contains("menu") || nombre.Contains("sidebar") || nombre.Contains("lateral"))
            {
                EstiloMenuLateral(panel);
            }
            else if (nombre.Contains("contenido") || nombre.Contains("content") || nombre.Contains("main"))
            {
                panel.BackColor = ColorBlanco;
                panel.Padding = new Padding(20);
            }
            else if (nombre.Contains("toolbar") || nombre.Contains("herramientas"))
            {
                panel.BackColor = ColorFondo;
                panel.Padding = new Padding(0, 8, 0, 8);
            }
        }


        // =============================================
        //  GROUPBOX
        // =============================================

        public static void EstiloGroupBox(GroupBox grp)
        {
            grp.Font = FuenteSmall;
            grp.ForeColor = ColorTextoMuted;
            grp.BackColor = Color.Transparent;
        }


        // =============================================
        //  LÍNEA SEPARADORA (usa un Panel de 1px)
        // =============================================

        /// <summary>
        /// Crea una línea divisora horizontal.
        /// Úsala debajo del título de un formulario.
        /// Ejemplo: panelTitulo.Controls.Add(UIHelper.CrearLinea(panelTitulo.Width));
        /// </summary>
        public static Panel CrearLinea(int ancho)
        {
            return new Panel
            {
                Height = 1,
                Width = ancho,
                BackColor = ColorBorde,
                Dock = DockStyle.Bottom
            };
        }


        // =============================================
        //  UTILIDAD — recorre todos los controles
        // =============================================

        private static System.Collections.Generic.IEnumerable<Control> ObtenerTodosLosControles(Control padre)
        {
            foreach (Control ctrl in padre.Controls)
            {
                yield return ctrl;
                foreach (Control hijo in ObtenerTodosLosControles(ctrl))
                    yield return hijo;
            }
        }
    }
}