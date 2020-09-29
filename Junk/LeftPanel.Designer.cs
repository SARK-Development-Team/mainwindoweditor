namespace MainWindowEditor
{
    partial class LeftPanel
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
            this.tabHome = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stagebuttonsPanel = new System.Windows.Forms.Panel();
            this.custommessageButton = new System.Windows.Forms.Button();
            this.sendchecklistButton = new System.Windows.Forms.Button();
            this.sendintroButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabHome.SuspendLayout();
            this.stagebuttonsPanel.SuspendLayout();
            this.tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.AutoScroll = true;
            this.tabHome.Controls.Add(this.propertyGrid1);
            this.tabHome.Controls.Add(this.button2);
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Controls.Add(this.stagebuttonsPanel);
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(538, 675);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Message Builder";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(78, 56);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(378, 396);
            this.propertyGrid1.TabIndex = 184;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 183;
            this.button2.Text = "Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 182;
            this.button1.Text = "Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stagebuttonsPanel
            // 
            this.stagebuttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stagebuttonsPanel.Controls.Add(this.panel1);
            this.stagebuttonsPanel.Controls.Add(this.custommessageButton);
            this.stagebuttonsPanel.Controls.Add(this.sendchecklistButton);
            this.stagebuttonsPanel.Controls.Add(this.sendintroButton);
            this.stagebuttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stagebuttonsPanel.Location = new System.Drawing.Point(3, 472);
            this.stagebuttonsPanel.Name = "stagebuttonsPanel";
            this.stagebuttonsPanel.Size = new System.Drawing.Size(532, 200);
            this.stagebuttonsPanel.TabIndex = 180;
            // 
            // custommessageButton
            // 
            this.custommessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custommessageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.custommessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.custommessageButton.FlatAppearance.BorderSize = 0;
            this.custommessageButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custommessageButton.ForeColor = System.Drawing.Color.White;
            this.custommessageButton.Location = new System.Drawing.Point(-773, 118);
            this.custommessageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.custommessageButton.Name = "custommessageButton";
            this.custommessageButton.Size = new System.Drawing.Size(189, 49);
            this.custommessageButton.TabIndex = 167;
            this.custommessageButton.Text = "Custom Email or Text";
            this.custommessageButton.UseVisualStyleBackColor = false;
            // 
            // sendchecklistButton
            // 
            this.sendchecklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendchecklistButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendchecklistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.sendchecklistButton.FlatAppearance.BorderSize = 0;
            this.sendchecklistButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendchecklistButton.ForeColor = System.Drawing.Color.White;
            this.sendchecklistButton.Location = new System.Drawing.Point(75, 118);
            this.sendchecklistButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendchecklistButton.Name = "sendchecklistButton";
            this.sendchecklistButton.Size = new System.Drawing.Size(0, 49);
            this.sendchecklistButton.TabIndex = 168;
            this.sendchecklistButton.Text = "Send only Checklist.";
            this.sendchecklistButton.UseVisualStyleBackColor = false;
            // 
            // sendintroButton
            // 
            this.sendintroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendintroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.sendintroButton.FlatAppearance.BorderSize = 2;
            this.sendintroButton.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendintroButton.ForeColor = System.Drawing.Color.White;
            this.sendintroButton.Location = new System.Drawing.Point(75, 48);
            this.sendintroButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendintroButton.Name = "sendintroButton";
            this.sendintroButton.Size = new System.Drawing.Size(0, 64);
            this.sendintroButton.TabIndex = 166;
            this.sendintroButton.Text = "Submit Introduction";
            this.sendintroButton.UseVisualStyleBackColor = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabHome);
            this.tabs.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(8, 8);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(546, 703);
            this.tabs.TabIndex = 113;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 200);
            this.panel1.TabIndex = 181;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(265, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 49);
            this.button3.TabIndex = 167;
            this.button3.Text = "Custom Email or Text";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(75, 118);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 49);
            this.button4.TabIndex = 168;
            this.button4.Text = "Send only Checklist.";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(75, 48);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(379, 64);
            this.button5.TabIndex = 166;
            this.button5.Text = "Submit Introduction";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // LeftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "LeftPanel";
            this.Size = new System.Drawing.Size(1321, 776);
            this.tabHome.ResumeLayout(false);
            this.stagebuttonsPanel.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Panel stagebuttonsPanel;
        private System.Windows.Forms.Button custommessageButton;
        private System.Windows.Forms.Button sendchecklistButton;
        private System.Windows.Forms.Button sendintroButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
