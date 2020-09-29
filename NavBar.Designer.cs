namespace MainWindowEditor
{
    partial class NavBar
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
            this.iconsPanel = new System.Windows.Forms.Panel();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addclientButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.hamburgerButton = new System.Windows.Forms.Button();
            this.iconsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconsPanel
            // 
            this.iconsPanel.BackColor = System.Drawing.Color.White;
            this.iconsPanel.Controls.Add(this.adminButton);
            this.iconsPanel.Controls.Add(this.button1);
            this.iconsPanel.Controls.Add(this.addclientButton);
            this.iconsPanel.Controls.Add(this.clientsButton);
            this.iconsPanel.Controls.Add(this.hamburgerButton);
            this.iconsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconsPanel.Location = new System.Drawing.Point(0, 0);
            this.iconsPanel.Name = "iconsPanel";
            this.iconsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.iconsPanel.Size = new System.Drawing.Size(45, 524);
            this.iconsPanel.TabIndex = 0;
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.Location = new System.Drawing.Point(60, 63);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(48, 17);
            this.clientsLabel.TabIndex = 1;
            this.clientsLabel.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admin";
            // 
            // adminButton
            // 
            this.adminButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.icons8_admin_settings_male_64;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminButton.Location = new System.Drawing.Point(5, 463);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(35, 56);
            this.adminButton.TabIndex = 13;
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MainWindowEditor.Properties.Resources.icons8_alarm_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(5, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 56);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addclientButton
            // 
            this.addclientButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.icons8_add_property_48;
            this.addclientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addclientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addclientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addclientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addclientButton.Location = new System.Drawing.Point(5, 93);
            this.addclientButton.Name = "addclientButton";
            this.addclientButton.Size = new System.Drawing.Size(35, 45);
            this.addclientButton.TabIndex = 11;
            this.addclientButton.UseVisualStyleBackColor = true;
            // 
            // clientsButton
            // 
            this.clientsButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.icons8_new_contact_64;
            this.clientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientsButton.Location = new System.Drawing.Point(5, 41);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(35, 52);
            this.clientsButton.TabIndex = 10;
            this.clientsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientsButton.UseVisualStyleBackColor = true;
            // 
            // hamburgerButton
            // 
            this.hamburgerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hamburgerButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.Hamburger_icon_svg;
            this.hamburgerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hamburgerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hamburgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburgerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hamburgerButton.Location = new System.Drawing.Point(5, 5);
            this.hamburgerButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.hamburgerButton.Name = "hamburgerButton";
            this.hamburgerButton.Padding = new System.Windows.Forms.Padding(5);
            this.hamburgerButton.Size = new System.Drawing.Size(35, 36);
            this.hamburgerButton.TabIndex = 9;
            this.hamburgerButton.UseVisualStyleBackColor = false;
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.iconsPanel);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(168, 524);
            this.iconsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel iconsPanel;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addclientButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button hamburgerButton;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
