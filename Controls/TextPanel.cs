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
    public partial class TextPanel : UserControl
    {
        string Name { get; set; }
        string Phone { get; set; }
        string placeholder = "Please start typing your message here, and click the button on the right to send.";

        public event EventHandler<MessageEventArgs> RecordText;
        public class MessageEventArgs : EventArgs
        {
            public string Name { get; set; }
            public string SMS { get; set; }
            public string Message { get; set; }
        }

        public TextPanel()
        {
            InitializeComponent();
            InitializeView();
        }

        void InitializeView()
        {
            backIconCircle.InitializeView(Assets.Icons["back"], Color.LightCyan);
            sendIconCircle.InitializeView(Assets.Icons["sms"], Color.LightCyan);

            backIconCircle.Click += (s, l) =>
            {
                Visible = false;
                (Parent.FindForm() as MainWindow).ReturnInfoView();
            };

            sendIconCircle.Click += SendText;
            textRichTextBox.Enter += sms_Enter;
            textRichTextBox.Enter += sms_Leave;
        }

        public void Reset(string name, string phone)
        {
            Name = name;
            Phone = phone;
            textTextBox.Text = phone;
            nameTextBox.Text = name;
        }

        private void sms_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTextBox.Text))
            {
                textRichTextBox.Text = placeholder;
                textRichTextBox.ForeColor = Color.Gray;
            }
        }
        private void sms_Enter(object sender, EventArgs e)
        {
            textRichTextBox.ForeColor = Color.Black;
            if (textRichTextBox.Text == placeholder)
            {
                textRichTextBox.Text = "";
            }
        }

        void SendText(object sender, EventArgs e)
        {
            Name = nameTextBox.Text;
            Phone = textTextBox.Text;

            string mainMessage = textRichTextBox.Text;
            if (string.IsNullOrEmpty(mainMessage) || mainMessage == placeholder)
            {
                MessageBox.Show("Please enter in an email to send before sending!", "Missing Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Please enter contact info to send to before sending!", "Missing Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Build and sends text message.
            string message = mainMessage + "\r\n\r\nSARK Insurance Services, INC.\r\n" +
                         "Add: 2092 Concourse Dr, Unit #25, San Jose, CA 95131 \r\n" +
                         "OH: 9AM - 6PM MO-FR, 10AM - 4PM SAT \r\n" +
                         "sark@sarkinsurance.com \r\n" +
                         "(408) 262-9190 \r\n";

            //try
            //{
            //    //await MessagingFunctions.SendSMS(Logger.NumbersOnly(Phone), message);
            //    //Logger.log("The client was successfully texted at " + Phone);
            //    RecordText.Invoke(null, new MessageEventArgs()
            //    {
            //        SMS = Logger.NumbersOnly(Phone),
            //        Message = message,
            //        Name = Name
            //    });
            //    textRichTextBox.Text = "";
            //}
            //catch (Exception)
            //{
            //    Logger.log("Text could not be sent. Please validate phone # or consult administrator.");
            //    return;
            //}
        }
    }
}
