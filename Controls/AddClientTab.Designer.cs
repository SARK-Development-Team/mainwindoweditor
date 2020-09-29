namespace MainWindowEditor
{
    partial class AddClientPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.alarmsDataGridView = new System.Windows.Forms.DataGridView();
            this.DOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(543, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Alarms";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmsDataGridView
            // 
            this.alarmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alarmsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOT,
            this.Name,
            this.Phone,
            this.Alarm});
            this.alarmsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alarmsDataGridView.Location = new System.Drawing.Point(0, 41);
            this.alarmsDataGridView.Name = "alarmsDataGridView";
            this.alarmsDataGridView.Size = new System.Drawing.Size(543, 527);
            this.alarmsDataGridView.TabIndex = 1;
            // 
            // DOT
            // 
            this.DOT.HeaderText = "DOT";
            this.DOT.Name = "DOT";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Alarm
            // 
            this.Alarm.HeaderText = "Alarm";
            this.Alarm.Name = "Alarm";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(125, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // AddClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alarmsDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddClientPanel";
            this.Size = new System.Drawing.Size(543, 568);
            ((System.ComponentModel.ISupportInitialize)(this.alarmsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView alarmsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarm;
        private System.Windows.Forms.Panel panel1;
    }
}
