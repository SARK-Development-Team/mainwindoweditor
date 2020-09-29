namespace MainWindowEditor
{
    partial class temp
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabHome);
            this.tabs.Controls.Add(this.tabClient);
            this.tabs.Controls.Add(this.adminTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(561, 900);
            this.tabs.TabIndex = 117;
            // 
            // tabHome
            // 
            this.tabHome.AutoScroll = true;
            this.tabHome.ForeColor = System.Drawing.Color.Black;
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(553, 872);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabClient
            // 
            this.tabClient.AutoScroll = true;
            this.tabClient.Location = new System.Drawing.Point(4, 24);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(553, 872);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Add Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // adminTab
            // 
            this.adminTab.Location = new System.Drawing.Point(4, 24);
            this.adminTab.Name = "adminTab";
            this.adminTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab.Size = new System.Drawing.Size(553, 872);
            this.adminTab.TabIndex = 1;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "temp";
            this.Size = new System.Drawing.Size(561, 900);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage adminTab;
    }
}
