using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class IconCircle : UserControl
    {
        IconSet IconData;
        Color CircleColor = Color.White;
        Color HoverColor = Color.Gray;
        Image CircleImage = null;
        int CirclePadding = 4;

        public IconCircle()
        {
            InitializeComponent();
            InitializeView(Assets.Icons["delete"], Color.MistyRose);
        }

        public void InitializeView(IconSet icon, Color hoverColor, int padding = 4, bool staticImage = false)
        {
            IconData = icon;
            CircleColor = icon.BackColor;
            HoverColor = hoverColor;
            CircleImage = icon.Image;
            CirclePadding = padding;

            if (!staticImage)
            {
                MouseEnter += (s, l) =>
                {
                    CircleColor = HoverColor;
                    OnPaint(new PaintEventArgs(CreateGraphics(), this.DisplayRectangle));
                };

                MouseLeave += (s, l) =>
                {
                    CircleColor = IconData.BackColor;
                    OnPaint(new PaintEventArgs(CreateGraphics(), this.DisplayRectangle));
                };
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size sqsize = new Size(e.ClipRectangle.Height, e.ClipRectangle.Height);

            int hdiff = 0;
            int vdiff = 0;
            if (e.ClipRectangle.Width > e.ClipRectangle.Height)
            {
                hdiff = e.ClipRectangle.Width - e.ClipRectangle.Height;
                sqsize = new Size(e.ClipRectangle.Height, e.ClipRectangle.Height);
            }
            else if (e.ClipRectangle.Height > e.ClipRectangle.Width)
            {
                vdiff = e.ClipRectangle.Height - e.ClipRectangle.Width;
                sqsize = new Size(e.ClipRectangle.Width, e.ClipRectangle.Width);
            }

            Rectangle square = new Rectangle(e.ClipRectangle.Location, sqsize);
            square.Offset(hdiff / 2, vdiff/2);
            var brush = new SolidBrush(CircleColor);
            gfx.FillEllipse(brush, square);
            if (CircleImage != null)
            {
                square.Inflate(-CirclePadding, -CirclePadding);
                gfx.DrawImage(CircleImage, square);
            }

        }
    }
}
