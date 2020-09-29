using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class MainWindow : Form
    {
        int i = 0;
        EmailPanel emailPanel;
        TextPanel textPanel;

        public MainWindow()
        {
            InitializeComponent();

            emailPanel = new EmailPanel();
            textPanel = new TextPanel();
            mainPanel.Controls.Add(emailPanel);
            mainPanel.Controls.Add(textPanel);
            emailPanel.Dock = DockStyle.Fill;
            textPanel.Dock = DockStyle.Fill;
            emailPanel.Visible = false;
            textPanel.Visible = false;
        }

        public void PrepareEmail()
        {
            emailPanel.Visible = true;
        }

        public void PrepareText()
        {
            textPanel.Visible = true;
        }

        public void ReturnInfoView()
        {
            clientinfoPanel.Visible = true;
        }
        //void EmailEditor()
        //{
        //    InitializeEmailComponent();

        //    foreach (Control ctr in mainsplitContainer.Panel2.Controls)
        //    {
        //        ctr.Visible = false;
        //    }

        //    mainsplitContainer.Panel2.Controls.Add(templatePanel);
        //    templatePanel.Visible = true;
        //}
    }
}
