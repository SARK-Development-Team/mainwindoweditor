using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowEditor.Controls
{
    public partial class IconLabelButton : UserControl
    {
        public string LabelText 
        { 
            get { return iconLabel.Text; }
            set { iconLabel.Text = value; }
        }

        public Font LabelFont
        {
            get { return iconLabel.Font; }
            set { iconLabel.Font = value; }
        }

        public float LabelRatio = 0.25f;

        public IconLabelButton()
        {
            InitializeComponent();
            icon.Click += (s, l) => InvokeOnClick(this, null);
        }

        public void InitializeView(IconSet iconSet, Color hoverColor, int padding = 4)
        {
            icon.InitializeView(iconSet, hoverColor, padding);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (LabelRatio < 1 && LabelRatio > 0)
            {
                Point labelloc = new Point(0, (int)(Height * (1 - LabelRatio)));
                iconLabel.Location = labelloc;
                iconLabel.Height = (int)(Height * LabelRatio);
            }
        }
    }
}
