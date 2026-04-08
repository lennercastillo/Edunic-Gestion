using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EduGestion
{
    public partial class Login : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Login()
        {
            InitializeComponent();

           
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 18, 18));

            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            btnCancel.TabIndex = 3;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Conectar con la capa de negocio para verificar credenciales.
            // Por ahora simulamos éxito si usuario == "admin" y pass == "1234"
            if (user == "admin" && pass == "1234")
            {
                MessageBox.Show("Bienvenido, " + user + ".", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Allow dragging the form from the right panel
        private void panelRight_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, (IntPtr)0xf012, IntPtr.Zero);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
            // Draw gradient background with a subtle diagonal
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(panelLeft.ClientRectangle,
                System.Drawing.Color.FromArgb(52, 152, 219), System.Drawing.Color.FromArgb(41, 128, 185), 45F))
            {
                e.Graphics.FillRectangle(brush, panelLeft.ClientRectangle);
            }

            // Draw rounded white card where logo sits
            var rect = new System.Drawing.Rectangle(30, 30, panelLeft.Width - 60, 160);
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 12;
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                e.Graphics.FillPath(System.Drawing.Brushes.White, path);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }
    }
}
