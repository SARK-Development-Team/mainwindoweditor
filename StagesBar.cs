using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class StagesBar : UserControl
    {
        List<PointyPanel> pointyPanels = new List<PointyPanel>();
        public StagesBar()
        {
            InitializeComponent();
            pointyPanels.Add(stage0PointyPanel);
            pointyPanels.Add(stage1PointyPanel);
            pointyPanels.Add(stage2PointyPanel);
            pointyPanels.Add(stage3PointyPanel);
            OnResize(null);

            InitializeStageBars(0);
        }

        void InitializeStageBars(int stage)
        {
            if (stage < pointyPanels.Count)
            {
                var pointy = pointyPanels[stage];
                pointy.ForeColor = pointy.hoverForeColor;
                pointy.BackColor = pointy.hoverBackColor;
                if (stage + 1 < pointyPanels.Count)
                {
                    pointyPanels[stage + 1].ForeColor = Color.WhiteSmoke;
                }

                pointy.InitializeEvents();

                pointy.Click += (s, l) => { InitializeStageBars(++stage); };
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //Pointiness describe how far away the "end" points of the triangle on the pointy side are from the right-side. The panels only need to overlap until
            //there is no more empty space on the right side.

            //Divide evenly. Let's assume that all the stages are equally important. Resizing then needs to have all the panels same height and width.
            int panelHeight = Height - Padding.Bottom;
            int panelWidth = (int)(Width/3.529f);
            int lastwidth = 0;

            foreach (Control control in Controls)
            {
                control.Location = new Point(lastwidth, Padding.Top);
                control.Height = panelHeight;
                control.Width = panelWidth;

                if (control is PointyPanel)
                {
                    lastwidth += (int)(control.Width * (control as PointyPanel).Pointiness);
                }
            }
        }
    }
}