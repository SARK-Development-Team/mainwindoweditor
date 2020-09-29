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
    public partial class ClientInfoPanel : UserControl
    {
        public ClientInfoPanel()
        {
            InitializeComponent();
            InitializeView();
        }

        public void InitializeView()
        {
            emailButton.InitializeView(Assets.Icons["email"], Color.Red);
            smsButton.InitializeView(Assets.Icons["sms"], Color.Red);
            alarmButton.InitializeView(Assets.Icons["sms"], Color.Green);
            transferButton.InitializeView(Assets.Icons["transfer"], Color.Blue);
            notinterestButton.InitializeView(Assets.Icons["history"], Color.Blue);
            alarmButton.Click += GetAlarm;
        }

        public void GetAlarm(object sender, EventArgs e)
        {
            Controls.AlarmSmallPanel alarmy = new Controls.AlarmSmallPanel();
            alarmy.Name = "alarmpanel";
            Controls.Add(alarmy);
            alarmy.BringToFront();
            var loc = alarmButton.Location;
            loc.Offset(allbuttonsPanel.Location);
            loc.Y -= 20;

            alarmy.Location = loc;
            alarmy.Visible = true;

            Point FindLocation(Control ctrl)
            {
                Point p;
                for (p = ctrl.Location; ctrl.Parent != null; ctrl = ctrl.Parent)
                    p.Offset(ctrl.Parent.Location);
                return p;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int panelheight = buttonsPanel.Height - buttonsPanel.Padding.Top - buttonsPanel.Padding.Bottom;
            int panelwidth = buttonsPanel.Width / (buttonsPanel.Controls.Count + 1);

            Point lastloc = new Point(panelwidth/2, buttonsPanel.Padding.Top);

            List<Controls.IconLabelButton> buttons = new List<Controls.IconLabelButton>()
            {
                emailButton,
                smsButton,
                alarmButton,
                transferButton,
                notinterestButton
            };
            //Goal: For the buttonsBar, center and resize all the controls from the center.
            foreach (var control in buttons)
            {
                if (control == notinterestButton)
                {
                    control.Height = panelheight;
                    control.Width = (int)(panelwidth * 1.2f);
                    control.Location = lastloc;
                    lastloc.X += (int)(panelwidth*1.2f);
                    continue;
                }

                control.Height = panelheight;
                control.Width = panelwidth;
                control.Location = lastloc;

                lastloc.X += panelwidth;
            }
        }
    }
}
