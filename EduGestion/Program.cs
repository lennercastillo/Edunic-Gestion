using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduGestion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show login first. If successful, open main form.
            using (var login = new Login())
            {
                var result = login.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Run(new Principal());
                }
            }
        }
    }
}
