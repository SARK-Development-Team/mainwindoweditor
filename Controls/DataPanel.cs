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
    public partial class DataPanel : UserControl
    {
        public MainWindow Main { get; set; }
        public DataPanel()
        {
            InitializeComponent();
        }
    }
}
