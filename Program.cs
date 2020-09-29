using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    public static class WinformsHelper
    {
        public static Control GetChild(this Control control, string name)
        {
            Control result = null;
            foreach (Control ctr in control.Controls)
            {
                if (ctr.Name == name)
                {
                    result = ctr;
                }
                else
                {
                    var rec = GetChild(ctr, name);
                    if (rec != null)
                    {
                        result = rec;
                    }
                }
            }

            return result;
        }

        public static Control GetSibling(this Control control, string name)
        {
            var parent = control.Parent.FindForm();
            return parent?.GetSibling(name);
        }

        public static Rectangle ShrinkBorder(Rectangle rect, int padding)
        {
            rect.X = rect.X + padding / 2;
            rect.Y = rect.Y + padding / 2;
            rect.Height = rect.Height - padding;
            rect.Width = rect.Width - padding;

            return rect;
        }
    }
}
