namespace MainWindowEditor
{
    partial class TestingPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingPanel));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.outerpanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel17.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.outerpanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(347, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 10);
            this.panel4.TabIndex = 5;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(193, 3);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(12);
            this.panel17.Size = new System.Drawing.Size(56, 59);
            this.panel17.TabIndex = 12;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel18.BackgroundImage")));
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(12, 12);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(32, 35);
            this.panel18.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(134, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(12);
            this.panel12.Size = new System.Drawing.Size(53, 59);
            this.panel12.TabIndex = 10;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(12, 12);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(29, 35);
            this.panel13.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(70, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(12);
            this.panel6.Size = new System.Drawing.Size(58, 59);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(34, 35);
            this.panel7.TabIndex = 0;
            // 
            // outerpanel
            // 
            this.outerpanel.Controls.Add(this.panel);
            this.outerpanel.Location = new System.Drawing.Point(3, 3);
            this.outerpanel.Name = "outerpanel";
            this.outerpanel.Padding = new System.Windows.Forms.Padding(12);
            this.outerpanel.Size = new System.Drawing.Size(61, 59);
            this.outerpanel.TabIndex = 7;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(37, 35);
            this.panel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.outerpanel);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel17);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 64);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // TestingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Name = "TestingPanel";
            this.Text = "TestingPanel";
            this.Load += new System.EventHandler(this.TestingPanel_Load);
            this.panel17.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.outerpanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel outerpanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}