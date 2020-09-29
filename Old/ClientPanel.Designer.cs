namespace MainWindowEditor
{
    partial class ClientPanel
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.rightinfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.transferButton = new MainWindowEditor.IconCircle();
            this.updateinfoButton = new System.Windows.Forms.Button();
            this.deleteclientButton = new MainWindowEditor.IconCircle();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new MainWindowEditor.Controls.Timeline();
            this.infoPanel.SuspendLayout();
            this.rightinfoPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.Controls.Add(this.rightinfoPanel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(520, 335);
            this.infoPanel.TabIndex = 1;
            // 
            // rightinfoPanel
            // 
            this.rightinfoPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rightinfoPanel.Controls.Add(this.transferButton);
            this.rightinfoPanel.Controls.Add(this.updateinfoButton);
            this.rightinfoPanel.Controls.Add(this.deleteclientButton);
            this.rightinfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightinfoPanel.Location = new System.Drawing.Point(0, 278);
            this.rightinfoPanel.Name = "rightinfoPanel";
            this.rightinfoPanel.Size = new System.Drawing.Size(520, 57);
            this.rightinfoPanel.TabIndex = 243;
            // 
            // transferButton
            // 
            this.transferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferButton.Location = new System.Drawing.Point(3, 3);
            this.transferButton.Name = "transferButton";
            this.transferButton.Padding = new System.Windows.Forms.Padding(9);
            this.transferButton.Size = new System.Drawing.Size(60, 60);
            this.transferButton.TabIndex = 241;
            // 
            // updateinfoButton
            // 
            this.updateinfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateinfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
            this.updateinfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.updateinfoButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfoButton.ForeColor = System.Drawing.Color.White;
            this.updateinfoButton.Location = new System.Drawing.Point(70, 3);
            this.updateinfoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateinfoButton.Name = "updateinfoButton";
            this.updateinfoButton.Size = new System.Drawing.Size(65, 61);
            this.updateinfoButton.TabIndex = 226;
            this.updateinfoButton.Text = "Update Info";
            this.updateinfoButton.UseVisualStyleBackColor = false;
            // 
            // deleteclientButton
            // 
            this.deleteclientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteclientButton.Location = new System.Drawing.Point(142, 3);
            this.deleteclientButton.Name = "deleteclientButton";
            this.deleteclientButton.Padding = new System.Windows.Forms.Padding(10);
            this.deleteclientButton.Size = new System.Drawing.Size(60, 60);
            this.deleteclientButton.TabIndex = 242;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.statusPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 335);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(520, 164);
            this.bottomPanel.TabIndex = 2;
            // 
            // statusPanel
            // 
            this.statusPanel.AutoScroll = true;
            this.statusPanel.AutoScrollMargin = new System.Drawing.Size(300, 141);
            this.statusPanel.AutoSize = true;
            this.statusPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(520, 164);
            this.statusPanel.TabIndex = 248;
            // 
            // ClientInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "ClientInfoPanel";
            this.Size = new System.Drawing.Size(520, 499);
            this.infoPanel.ResumeLayout(false);
            this.rightinfoPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button updateinfoButton;
        private System.Windows.Forms.Panel bottomPanel;
        private Controls.Timeline statusPanel;
        private IconCircle deleteclientButton;
        private IconCircle transferButton;
        private System.Windows.Forms.FlowLayoutPanel rightinfoPanel;
    }
}
