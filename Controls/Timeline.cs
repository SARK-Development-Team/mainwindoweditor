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
    public partial class Timeline : UserControl
    {
        bool expanded = false;
        public Timeline()
        {
            InitializeComponent();
            addcommentButton.InitializeView(Assets.Icons["add"], Color.LightCyan);
            timelineItem1.Item = new TimelineItemModel()
            {
                Author = "",
                Description = "No history for this client was found.",
                Date = DateTime.Now,
                IconData = Assets.Icons["history"]
            };
            timelineItem1.InitializeView();
        }

        public void AddItem(LogItem item)
        {
            if (timelineItem1.Visible)
            {
                timelineItem1.Visible = false;
            }

            var statusItem = new TimelineItem(item);
            statusItem.Dock = System.Windows.Forms.DockStyle.Top;
            statusItem.Name = "statusItem" + (Controls.Count + 1).ToString();
            statusItem.TabIndex = 1;

            Controls.Add(statusItem);
        }
    }
}
