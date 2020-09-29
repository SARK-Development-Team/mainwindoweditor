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
    public partial class AlarmSmallPanel : UserControl
    {
        DateTime remindTime = DateTime.Now;
        string placeholder = "Remind me in...";
        Dictionary<string, TimeSpan> times = new Dictionary<string, TimeSpan>()
        {
            { "Remind me in one hour...", TimeSpan.FromHours(1) },
            { "Remind me in two hours...", TimeSpan.FromHours(2) },
            { "Remind me in one day...", TimeSpan.FromDays(1) },
            { "Remind me next week...", TimeSpan.FromDays(7) }
        };
        public AlarmSmallPanel()
        {
            InitializeComponent();
            descTextBox.Text = placeholder;
            dateTimePicker.ValueChanged += DateTimeChanged;
            timeTimePicker.ValueChanged += DateTimeChanged;
        }

        void DisplayDate(DateTime time)
        {
            remindTime = time;
            descTextBox.Text = time.ToString("MMMM dd, yyyy | hh:mm tt");
        }

        void DateTimeChanged(object sender, EventArgs e)
        {
            DateTime day = dateTimePicker.Value.Date;
            DateTime time = timeTimePicker.Value;
            TimeSpan timespan = new TimeSpan(0, time.Hour, time.Minute, time.Second, time.Millisecond);

            DateTime currtime = day.Add(timespan);
            DisplayDate(currtime);
        }
    }
}
