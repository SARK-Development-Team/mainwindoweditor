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
        public TimelineItemModel Item { get; set; }
        Dictionary<LogItem.Event, IconSet> eventsMap = new Dictionary<LogItem.Event, IconSet>()
        {
            {LogItem.Event.Client_Added, Assets.Icons["add"]},
            {LogItem.Event.Client_Deleted, Assets.Icons["delete"]},
            {LogItem.Event.Client_Updated, Assets.Icons["update"]},
            {LogItem.Event.Comment, Assets.Icons["comments"]},
            {LogItem.Event.Email_Sent, Assets.Icons["email"]},
            {LogItem.Event.SMS_Sent, Assets.Icons["sms"]},
            {LogItem.Event.Placeholder, Assets.Icons["history"]},
            {LogItem.Event.Transfer, Assets.Icons["transfer"]},
            {LogItem.Event.Stage_0, Assets.StagesIcons[0]},
            {LogItem.Event.Stage_1, Assets.StagesIcons[1]},
            {LogItem.Event.Stage_2, Assets.StagesIcons[2]},
            {LogItem.Event.Stage_3, Assets.StagesIcons[3]},
        };
        public TimelineItem()
        {
            InitializeComponent();
        }

        public TimelineItem(LogItem item)
        {
            InitializeComponent();

            Item = new TimelineItemModel()
            {
                Description = item.Description,
                Author = item.Author ?? "System - Generated",
                Date = item.Date,
                IconData = eventsMap[item.StatusEvent]
            };

            InitializeView();
        }

        public void InitializeView()
        {
            iconCircle.InitializeView(Item.IconData, Color.LightGoldenrodYellow);

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

    public class TimelineItemModel
    {
        public string Description { get; set; }
        public string Author { get; set; }
        public IconSet IconData { get; set; }
        public DateTime Date { get; set; }
    }
}
