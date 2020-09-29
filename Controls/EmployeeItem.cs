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
    public partial class EmployeeItem : UserControl
    {
        public EmployeeItem()
        {
            InitializeComponent();
            InitializeView();
        }

        void InitializeView()
        {

            status1Panel.BackColor = Color.White;
            status2Panel.BackColor = Assets.CellStyles[Client.ContactStatus.Purchased_Policy].BackColor;
            status3Panel.BackColor = Assets.CellStyles[Client.ContactStatus.Not_Interested].BackColor;
            status4Panel.BackColor = Assets.CellStyles[Client.ContactStatus.Interested].BackColor;
            status5Panel.BackColor = Assets.CellStyles[Client.ContactStatus.Contact_Later].BackColor;
            status6Panel.BackColor = Assets.CellStyles[Client.ContactStatus.Future_Prospect].BackColor;
        }

        public void UpdateTotals(Dictionary<string, Client> clients)
        {
            totalLabel.Text = "Total: " + clients.Count;
            status1totalLabel.Text = "Not Contacted: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Not_Contacted).Count();
            status2totalLabel.Text = "Purchased: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Purchased_Policy).Count();
            status3totalLabel.Text = "Not Interested: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Not_Interested).Count();
            status4totalLabel.Text = "Interested: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Interested).Count();
            status5totalLabel.Text = "Contact Later: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Contact_Later).Count();
            status6totalLabel.Text = "Future Prospect: " + clients.Where(Cli => Cli.Value.Data.Status == Client.ContactStatus.Future_Prospect).Count();
        }
    }
}
