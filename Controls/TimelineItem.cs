using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class TimelineItem : UserControl
    {
        public StatusItemModel Item { get; set; }
        public TimelineItem()
        {
            InitializeComponent();
        }

        public TimelineItem(StatusItemModel item)
        {
            Item = item;
            InitializeComponent();
            InitializeView();
        }

        public void InitializeView()
        {
            imageinnerPanel.BackColor = Item.IconData.BackColor;
            imageinnerPanel.BackgroundImage = Item.IconData.Image;
            imageinnerPanel.BackgroundImageLayout = ImageLayout.Stretch;

            imageouterPanel.Paint += (s, pevent) =>
            {
                var gfx = pevent.Graphics;
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var brush = new SolidBrush(Item.IconData.BackColor);
                Rectangle square = new Rectangle(pevent.ClipRectangle.X, pevent.ClipRectangle.Y, pevent.ClipRectangle.Height, pevent.ClipRectangle.Height);
                gfx.FillEllipse(brush, WinformsHelper.ShrinkBorder(square, -1));
            };

            descriptionTextBox.Text = Item.Description;

            if (Item.Date > DateTime.Today.Date)
            {
                authorLabel.Text = Item.Author + " - " + Item.Date.ToShortTimeString();
            }
            else
            {
                authorLabel.Text = Item.Author + " - " + Item.Date.ToShortDateString();
            }
        }
    }

    public class StatusItemModel
    {
        public string Description { get; set; }
        public string Author { get; set; }
        public IconSet IconData { get; set; }
        public DateTime Date { get; set; }
    }
}
