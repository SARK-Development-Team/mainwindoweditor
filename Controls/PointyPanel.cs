using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MainWindowEditor
{
    public partial class PointyPanel : UserControl
    {
        public float BorderThickness { get; set; } = 5f;
        public string NameText
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }
        public float CornerRadius { get; set; } = 5f;
        public float Pointiness { get; set; } = 0.85f;

        public Color hoverBackColor { get; set; } = Color.RoyalBlue;
        public Color hoverForeColor { get; set; } = Color.Black;
        public Color hoveringBackColor { get; set; } = Color.LightSkyBlue;

        public PointyPanel()
        {
            InitializeComponent();
            BackColor = Color.LightGray;
            ForeColor = Color.LightSlateGray;
        }

        public PointyPanel(string name, float _borderthick, float _radius, float _pointness, Color foreColor, Color backColor, Color invertColor) : this()
        {
            BorderThickness = _borderthick;
            CornerRadius = _radius;
            Pointiness = _pointness;
            hoverForeColor = foreColor;
            hoverBackColor = backColor;
            hoveringBackColor = invertColor;
        }

        public void InitializeEvents()
        {
            nameLabel.MouseEnter += MouseEnter_Change;
            nameLabel.MouseLeave += MouseLeave_Change;
            nameLabel.Click += (s, l) => OnClick(null);
            ForeColor = hoverForeColor;
            BackColor = hoverBackColor;
        }

       
        public void MouseEnter_Change(object sender, EventArgs e)
        {
            ForeColor = Color.White;
            BackColor = hoveringBackColor;
        }

        public void MouseLeave_Change(object sender, EventArgs e)
        {
            ForeColor = hoverForeColor;
            BackColor = hoverBackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GeneratePointyRoundedRectangle(Rect, CornerRadius, Pointiness))
            {
                Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.White, BorderThickness))
                {
                    pen.Alignment = PenAlignment.Outset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        private static GraphicsPath GeneratePointyRoundedRectangle(RectangleF rectangle, float radius, float pointiness)
        {
            float diameter;

            GraphicsPath path = new GraphicsPath();
            if (radius <= 0.0F)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();
                return path;
            }
            else
            {
                //Upper left corner.
                diameter = radius * 2.0F;
                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(rectangle.Location, sizeF);
                path.AddArc(arc, -90, -90);

                //Bottom left corner.
                arc.X = rectangle.Left;
                arc.Y = rectangle.Bottom - diameter;
                path.AddArc(arc, -180, -90);

                //Makes lines for triangle.
                path.AddLine(rectangle.Left + radius, rectangle.Bottom, (rectangle.Right) * pointiness, rectangle.Bottom);
                path.AddLine(rectangle.Right * pointiness, rectangle.Bottom, rectangle.Right, rectangle.Top + rectangle.Height / 2);
                path.AddLine(rectangle.Right, rectangle.Top + rectangle.Height / 2, rectangle.Right * pointiness, rectangle.Top);

                path.CloseFigure();
            }

            return path;
        }
    }
}
