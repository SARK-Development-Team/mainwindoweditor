using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    partial class DataPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPanel));
            this.searchgridPanel = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.statussearchComboBox = new System.Windows.Forms.ComboBox();
            this.statussearchLabel = new System.Windows.Forms.Label();
            this.csrComboBox = new System.Windows.Forms.ComboBox();
            this.csrLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.status6totalLabel = new System.Windows.Forms.Label();
            this.status6Panel = new System.Windows.Forms.Panel();
            this.status5totalLabel = new System.Windows.Forms.Label();
            this.status5Panel = new System.Windows.Forms.Panel();
            this.status4totalLabel = new System.Windows.Forms.Label();
            this.status3totalLabel = new System.Windows.Forms.Label();
            this.status2totalLabel = new System.Windows.Forms.Label();
            this.status1totalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.status4Panel = new System.Windows.Forms.Panel();
            this.status3Panel = new System.Windows.Forms.Panel();
            this.status2Panel = new System.Windows.Forms.Panel();
            this.status1Panel = new System.Windows.Forms.Panel();
            this.vrsLabel = new System.Windows.Forms.Label();
            this.clientdataviewPanel = new System.Windows.Forms.Panel();
            this.clientDataView = new System.Windows.Forms.DataGridView();
            this.Favorite = new System.Windows.Forms.DataGridViewImageColumn();
            this.DOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saferwebsiteLink = new System.Windows.Forms.ToolStripMenuItem();
            this.soswebsiteLink = new System.Windows.Forms.ToolStripMenuItem();
            this.searchgridPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.clientdataviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataView)).BeginInit();
            this.gridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchgridPanel
            // 
            this.searchgridPanel.AutoScroll = true;
            this.searchgridPanel.AutoScrollMinSize = new System.Drawing.Size(900, 0);
            this.searchgridPanel.Controls.Add(this.searchBar);
            this.searchgridPanel.Controls.Add(this.searchType);
            this.searchgridPanel.Controls.Add(this.statussearchComboBox);
            this.searchgridPanel.Controls.Add(this.statussearchLabel);
            this.searchgridPanel.Controls.Add(this.csrComboBox);
            this.searchgridPanel.Controls.Add(this.csrLabel);
            this.searchgridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchgridPanel.Location = new System.Drawing.Point(0, 0);
            this.searchgridPanel.Name = "searchgridPanel";
            this.searchgridPanel.Size = new System.Drawing.Size(924, 57);
            this.searchgridPanel.TabIndex = 175;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBar.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(13, 22);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(250, 23);
            this.searchBar.TabIndex = 144;
            this.searchBar.Text = "Search for a client...";
            // 
            // searchType
            // 
            this.searchType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchType.Items.AddRange(new object[] {
            "MC",
            "DOT",
            "Name",
            "Email",
            "Phone",
            "Status",
            "Address",
            "# of Trucks",
            "# of Drivers"});
            this.searchType.Location = new System.Drawing.Point(275, 22);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(88, 21);
            this.searchType.TabIndex = 145;
            // 
            // statussearchComboBox
            // 
            this.statussearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statussearchComboBox.FormattingEnabled = true;
            this.statussearchComboBox.Location = new System.Drawing.Point(805, 22);
            this.statussearchComboBox.Name = "statussearchComboBox";
            this.statussearchComboBox.Size = new System.Drawing.Size(105, 21);
            this.statussearchComboBox.TabIndex = 147;
            // 
            // statussearchLabel
            // 
            this.statussearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statussearchLabel.AutoSize = true;
            this.statussearchLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statussearchLabel.Location = new System.Drawing.Point(765, 26);
            this.statussearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statussearchLabel.Name = "statussearchLabel";
            this.statussearchLabel.Size = new System.Drawing.Size(39, 15);
            this.statussearchLabel.TabIndex = 146;
            this.statussearchLabel.Text = "Status";
            // 
            // csrComboBox
            // 
            this.csrComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.csrComboBox.FormattingEnabled = true;
            this.csrComboBox.Items.AddRange(new object[] {
            "All Representatives"});
            this.csrComboBox.Location = new System.Drawing.Point(575, 22);
            this.csrComboBox.Name = "csrComboBox";
            this.csrComboBox.Size = new System.Drawing.Size(175, 21);
            this.csrComboBox.TabIndex = 163;
            // 
            // csrLabel
            // 
            this.csrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.csrLabel.AutoSize = true;
            this.csrLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csrLabel.Location = new System.Drawing.Point(540, 24);
            this.csrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csrLabel.Name = "csrLabel";
            this.csrLabel.Size = new System.Drawing.Size(31, 17);
            this.csrLabel.TabIndex = 164;
            this.csrLabel.Text = "CSR";
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoScroll = true;
            this.bottomPanel.AutoScrollMinSize = new System.Drawing.Size(850, 0);
            this.bottomPanel.Controls.Add(this.status6totalLabel);
            this.bottomPanel.Controls.Add(this.status6Panel);
            this.bottomPanel.Controls.Add(this.status5totalLabel);
            this.bottomPanel.Controls.Add(this.status5Panel);
            this.bottomPanel.Controls.Add(this.status4totalLabel);
            this.bottomPanel.Controls.Add(this.status3totalLabel);
            this.bottomPanel.Controls.Add(this.status2totalLabel);
            this.bottomPanel.Controls.Add(this.status1totalLabel);
            this.bottomPanel.Controls.Add(this.totalLabel);
            this.bottomPanel.Controls.Add(this.status4Panel);
            this.bottomPanel.Controls.Add(this.status3Panel);
            this.bottomPanel.Controls.Add(this.status2Panel);
            this.bottomPanel.Controls.Add(this.status1Panel);
            this.bottomPanel.Controls.Add(this.vrsLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 555);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(924, 68);
            this.bottomPanel.TabIndex = 177;
            // 
            // status6totalLabel
            // 
            this.status6totalLabel.AutoSize = true;
            this.status6totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status6totalLabel.Location = new System.Drawing.Point(587, 23);
            this.status6totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status6totalLabel.Name = "status6totalLabel";
            this.status6totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status6totalLabel.TabIndex = 172;
            this.status6totalLabel.Text = "Total:";
            // 
            // status6Panel
            // 
            this.status6Panel.BackColor = System.Drawing.Color.Magenta;
            this.status6Panel.Location = new System.Drawing.Point(565, 25);
            this.status6Panel.Name = "status6Panel";
            this.status6Panel.Size = new System.Drawing.Size(15, 15);
            this.status6Panel.TabIndex = 171;
            // 
            // status5totalLabel
            // 
            this.status5totalLabel.AutoSize = true;
            this.status5totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status5totalLabel.Location = new System.Drawing.Point(505, 23);
            this.status5totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status5totalLabel.Name = "status5totalLabel";
            this.status5totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status5totalLabel.TabIndex = 170;
            this.status5totalLabel.Text = "Total:";
            // 
            // status5Panel
            // 
            this.status5Panel.BackColor = System.Drawing.Color.Magenta;
            this.status5Panel.Location = new System.Drawing.Point(483, 25);
            this.status5Panel.Name = "status5Panel";
            this.status5Panel.Size = new System.Drawing.Size(15, 15);
            this.status5Panel.TabIndex = 169;
            // 
            // status4totalLabel
            // 
            this.status4totalLabel.AutoSize = true;
            this.status4totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status4totalLabel.Location = new System.Drawing.Point(421, 23);
            this.status4totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status4totalLabel.Name = "status4totalLabel";
            this.status4totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status4totalLabel.TabIndex = 168;
            this.status4totalLabel.Text = "Total:";
            // 
            // status3totalLabel
            // 
            this.status3totalLabel.AutoSize = true;
            this.status3totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status3totalLabel.Location = new System.Drawing.Point(343, 23);
            this.status3totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status3totalLabel.Name = "status3totalLabel";
            this.status3totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status3totalLabel.TabIndex = 167;
            this.status3totalLabel.Text = "Total:";
            // 
            // status2totalLabel
            // 
            this.status2totalLabel.AutoSize = true;
            this.status2totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2totalLabel.Location = new System.Drawing.Point(258, 23);
            this.status2totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status2totalLabel.Name = "status2totalLabel";
            this.status2totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status2totalLabel.TabIndex = 166;
            this.status2totalLabel.Text = "Total:";
            // 
            // status1totalLabel
            // 
            this.status1totalLabel.AutoSize = true;
            this.status1totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1totalLabel.Location = new System.Drawing.Point(173, 23);
            this.status1totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status1totalLabel.Name = "status1totalLabel";
            this.status1totalLabel.Size = new System.Drawing.Size(46, 19);
            this.status1totalLabel.TabIndex = 165;
            this.status1totalLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(24, 21);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(46, 19);
            this.totalLabel.TabIndex = 162;
            this.totalLabel.Text = "Total:";
            // 
            // status4Panel
            // 
            this.status4Panel.BackColor = System.Drawing.Color.Magenta;
            this.status4Panel.Location = new System.Drawing.Point(399, 25);
            this.status4Panel.Name = "status4Panel";
            this.status4Panel.Size = new System.Drawing.Size(15, 15);
            this.status4Panel.TabIndex = 161;
            // 
            // status3Panel
            // 
            this.status3Panel.BackColor = System.Drawing.Color.Red;
            this.status3Panel.Location = new System.Drawing.Point(321, 25);
            this.status3Panel.Name = "status3Panel";
            this.status3Panel.Size = new System.Drawing.Size(15, 15);
            this.status3Panel.TabIndex = 160;
            // 
            // status2Panel
            // 
            this.status2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.status2Panel.Location = new System.Drawing.Point(236, 25);
            this.status2Panel.Name = "status2Panel";
            this.status2Panel.Size = new System.Drawing.Size(15, 15);
            this.status2Panel.TabIndex = 159;
            // 
            // status1Panel
            // 
            this.status1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.status1Panel.Location = new System.Drawing.Point(151, 25);
            this.status1Panel.Name = "status1Panel";
            this.status1Panel.Size = new System.Drawing.Size(15, 15);
            this.status1Panel.TabIndex = 158;
            // 
            // vrsLabel
            // 
            this.vrsLabel.AutoSize = true;
            this.vrsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.vrsLabel.Font = new System.Drawing.Font("Nirmala UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrsLabel.Location = new System.Drawing.Point(850, 0);
            this.vrsLabel.Margin = new System.Windows.Forms.Padding(4);
            this.vrsLabel.Name = "vrsLabel";
            this.vrsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.vrsLabel.Size = new System.Drawing.Size(80, 11);
            this.vrsLabel.TabIndex = 157;
            this.vrsLabel.Text = "Vrs.16.6.30128.74";
            // 
            // clientdataviewPanel
            // 
            this.clientdataviewPanel.Controls.Add(this.clientDataView);
            this.clientdataviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientdataviewPanel.Location = new System.Drawing.Point(0, 57);
            this.clientdataviewPanel.Name = "clientdataviewPanel";
            this.clientdataviewPanel.Padding = new System.Windows.Forms.Padding(10);
            this.clientdataviewPanel.Size = new System.Drawing.Size(924, 498);
            this.clientdataviewPanel.TabIndex = 178;
            // 
            // clientDataView
            // 
            this.clientDataView.AllowUserToAddRows = false;
            this.clientDataView.AllowUserToDeleteRows = false;
            this.clientDataView.AllowUserToOrderColumns = true;
            this.clientDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.clientDataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.clientDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Favorite,
            this.DOT,
            this.MC,
            this.ClientName,
            this.Phone,
            this.ZIP,
            this.ClientStatus,
            this.DateUpdated});
            this.clientDataView.ContextMenuStrip = this.gridContextMenuStrip;
            this.clientDataView.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.clientDataView.Location = new System.Drawing.Point(10, 10);
            this.clientDataView.Margin = new System.Windows.Forms.Padding(100);
            this.clientDataView.Name = "clientDataView";
            this.clientDataView.ReadOnly = true;
            this.clientDataView.RowHeadersVisible = false;
            this.clientDataView.Size = new System.Drawing.Size(904, 478);
            this.clientDataView.TabIndex = 177;
            // 
            // Favorite
            // 
            this.Favorite.HeaderText = "";
            this.Favorite.Image = ((System.Drawing.Image)(resources.GetObject("Favorite.Image")));
            this.Favorite.Name = "Favorite";
            this.Favorite.ReadOnly = true;
            this.Favorite.Width = 5;
            // 
            // DOT
            // 
            this.DOT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOT.FillWeight = 50F;
            this.DOT.HeaderText = "DOT";
            this.DOT.MinimumWidth = 20;
            this.DOT.Name = "DOT";
            this.DOT.ReadOnly = true;
            // 
            // MC
            // 
            this.MC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MC.FillWeight = 50F;
            this.MC.HeaderText = "MC";
            this.MC.MinimumWidth = 20;
            this.MC.Name = "MC";
            this.MC.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.FillWeight = 150F;
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.FillWeight = 65F;
            this.Phone.HeaderText = "Phone #";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ZIP
            // 
            this.ZIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZIP.FillWeight = 40F;
            this.ZIP.HeaderText = "ZIP";
            this.ZIP.Name = "ZIP";
            this.ZIP.ReadOnly = true;
            // 
            // ClientStatus
            // 
            this.ClientStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientStatus.FillWeight = 50F;
            this.ClientStatus.HeaderText = "Status";
            this.ClientStatus.Name = "ClientStatus";
            this.ClientStatus.ReadOnly = true;
            // 
            // DateUpdated
            // 
            this.DateUpdated.HeaderText = "Date Updated";
            this.DateUpdated.Name = "DateUpdated";
            this.DateUpdated.ReadOnly = true;
            this.DateUpdated.Width = 99;
            // 
            // gridContextMenuStrip
            // 
            this.gridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenuItem,
            this.saferwebsiteLink,
            this.soswebsiteLink});
            this.gridContextMenuStrip.Name = "gridContextMenuStrip";
            this.gridContextMenuStrip.Size = new System.Drawing.Size(220, 70);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.Enabled = false;
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(219, 22);
            this.infoMenuItem.Text = "infoMenuItem";
            // 
            // saferwebsiteLink
            // 
            this.saferwebsiteLink.Image = ((System.Drawing.Image)(resources.GetObject("saferwebsiteLink.Image")));
            this.saferwebsiteLink.Name = "saferwebsiteLink";
            this.saferwebsiteLink.Size = new System.Drawing.Size(219, 22);
            this.saferwebsiteLink.Text = "SAFER Website";
            // 
            // soswebsiteLink
            // 
            this.soswebsiteLink.Image = ((System.Drawing.Image)(resources.GetObject("soswebsiteLink.Image")));
            this.soswebsiteLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soswebsiteLink.Name = "soswebsiteLink";
            this.soswebsiteLink.Size = new System.Drawing.Size(219, 22);
            this.soswebsiteLink.Text = "Secretary of State Website...";
            // 
            // DataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientdataviewPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.searchgridPanel);
            this.Name = "DataPanel";
            this.Size = new System.Drawing.Size(924, 623);
            this.searchgridPanel.ResumeLayout(false);
            this.searchgridPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.clientdataviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataView)).EndInit();
            this.gridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchgridPanel;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.ComboBox statussearchComboBox;
        private System.Windows.Forms.Label statussearchLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label status6totalLabel;
        private System.Windows.Forms.Panel status6Panel;
        private System.Windows.Forms.Label status5totalLabel;
        private System.Windows.Forms.Panel status5Panel;
        private System.Windows.Forms.Label status4totalLabel;
        private System.Windows.Forms.Label status3totalLabel;
        private System.Windows.Forms.Label status2totalLabel;
        private System.Windows.Forms.Label status1totalLabel;
        private System.Windows.Forms.Label csrLabel;
        private System.Windows.Forms.ComboBox csrComboBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel status4Panel;
        private System.Windows.Forms.Panel status3Panel;
        private System.Windows.Forms.Panel status2Panel;
        private System.Windows.Forms.Panel status1Panel;
        private System.Windows.Forms.Label vrsLabel;
        private System.Windows.Forms.Panel clientdataviewPanel;
        private System.Windows.Forms.DataGridView clientDataView;
        private ContextMenuStrip gridContextMenuStrip;
        private ToolStripMenuItem saferwebsiteLink;
        private ToolStripMenuItem soswebsiteLink;
        private ToolStripMenuItem infoMenuItem;
        private DataGridViewImageColumn Favorite;
        private DataGridViewTextBoxColumn DOT;
        private DataGridViewTextBoxColumn MC;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn ZIP;
        private DataGridViewTextBoxColumn ClientStatus;
        private DataGridViewTextBoxColumn DateUpdated;
    }
}
