using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class TestingPanel : Form
    {
        public TestingPanel()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void outerpanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, e.ClipRectangle);
            var pen = new Pen(Color.Red, 10);
            e.Graphics.DrawLine(pen, 
                new Point(e.ClipRectangle.Right, e.ClipRectangle.Y + e.ClipRectangle.Height/2),
                new Point(e.ClipRectangle.Right + 50, e.ClipRectangle.Y + e.ClipRectangle.Height / 2));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestingPanel_Load(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}