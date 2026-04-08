using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduGestion
{
    public static class FormStyles
    {
        public static void ApplyCompactStyle(Form form)
        {
            if (form == null) return;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ClientSize = new Size(384, 301);

            // Adjust top-level controls
            foreach (Control control in form.Controls)
            {
                // Standardize groupboxes to the same size and position
                if (control is GroupBox gb)
                {
                    gb.Location = new Point(12, 12);
                    gb.Size = new Size(360, 240);
                    try { gb.Font = new Font(gb.Font.FontFamily, 10F); } catch { }

                    // Adjust child controls inside the groupbox
                    foreach (Control inner in gb.Controls)
                    {
                        // Keep vertical spacing by using existing Y coordinate
                        int y = inner.Location.Y;

                        if (inner is Label lbl)
                        {
                            lbl.Location = new Point(16, y);
                            lbl.AutoSize = true;
                        }
                        else if (inner is TextBox || inner is ComboBox || inner is DateTimePicker || inner is CheckedListBox)
                        {
                            inner.Location = new Point(120, y);
                            inner.Width = 220;
                        }
                        else
                        {
                            // leave other controls as-is
                        }
                    }
                }

                // Standardize common buttons
                if (control is Button btn)
                {
                    if (string.Equals(btn.Name, "btnGuardar", StringComparison.OrdinalIgnoreCase))
                    {
                        btn.Size = new Size(75, 23);
                        btn.Location = new Point(216, 264);
                    }
                    else if (string.Equals(btn.Name, "btnCancelar", StringComparison.OrdinalIgnoreCase))
                    {
                        btn.Size = new Size(75, 23);
                        btn.Location = new Point(297, 264);
                    }
                }
            }
        }
    }
}
