using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;

namespace MainWindowEditor
{
    public partial class EmailPanel : UserControl
    {
        string Name { get; set; }
        string Email { get; set; }
        string placeholder = "Please start typing your message here, and click the button on the right to send.";

        public event EventHandler<MessageEventArgs> RecordEmail;
        public class MessageEventArgs : EventArgs
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }

        public EmailPanel()
        {
            InitializeComponent();
            InitializeView();
        }

        void InitializeView()
        {
            backIconCircle.InitializeView(Assets.Icons["back"], Color.LightBlue);
            sendIconCircle.InitializeView(Assets.Icons["email"], Color.LightBlue);

            backIconCircle.Click += (s, l) =>
            {
                Visible = false;
                (Parent.FindForm() as MainWindow).ReturnInfoView();
            };

            sendIconCircle.Click += SendEmail;
            emailRichTextBox.Enter += email_Enter;
            emailRichTextBox.Enter += email_Leave;
        }

        public void Reset(string name, string email)
        {
            Name = name;
            Email = email;
            emailTextBox.Text = email;
            nameTextBox.Text = name;
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailRichTextBox.Text = placeholder;
                emailRichTextBox.ForeColor = Color.Gray;
            }
        }
        private void email_Enter(object sender, EventArgs e)
        {
            emailRichTextBox.ForeColor = Color.Black;
            if (emailRichTextBox.Text == placeholder)
            {
                emailRichTextBox.Text = "";
            }
        }

        void SendEmail(object sender, EventArgs e)
        {
            Name = nameTextBox.Text;
            Email = emailTextBox.Text;

            string mainMessage = emailRichTextBox.Text;
            if (string.IsNullOrEmpty(mainMessage) || mainMessage == placeholder)
            {
                MessageBox.Show("Please enter in an email to send before sending!", "Missing Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please enter contact info to send to before sending!", "Missing Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ////Builds and sends email.
            //string filepath = FilePaths.TemplatesFolder + "ClientCustom.html";
            //MimeKit.BodyBuilder body = new MimeKit.BodyBuilder();
            //if (File.Exists(filepath))
            //{
            //    Logger.log("Sending email to " + Email);

            //    string emailcontents = File.ReadAllText(filepath);
            //    string subject = "SARK Insurance Services, Incoming Message";

            //    TextInfo info = new CultureInfo("en-US", false).TextInfo;
            //    emailcontents = emailcontents.Replace("preview.Text", "You have recieved a custom message from SARK Insurance ...");
            //    emailcontents = emailcontents.Replace("subject.Text", subject);
            //    emailcontents = emailcontents.Replace("message.Text", mainMessage.ToHtml());
            //    emailcontents = emailcontents.Replace("client.Name", info.ToTitleCase(Name.ToLowerInvariant()));
            //    body.HtmlBody = emailcontents;

            //    try
            //    {
            //        await Task.Run(() => MailFunctions.emailMessage(Email, subject, body));
            //        RecordMessage.Invoke(null, new MessageEventArgs()
            //        {
            //            Email = Email,
            //            Name = Name,
            //            Message = mainMessage
            //        });
            //        emailRichTextBox.Text = "";
            //        Logger.log("Email has been successfully sent to " + Email);
            //    }
            //    catch (Exception)
            //    {
            //        Logger.log("Email could not be sent. Please validate email or consult administrator.");
            //        return;
            //    }
            //}
            //else
            //{
            //    throw new FileNotFoundException("Custom message template could not be found.");
            //}
        }
    }
}
