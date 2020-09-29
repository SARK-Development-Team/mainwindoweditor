namespace MainWindowEditor
{
    partial class MainWindow
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
            this.mainsplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.clientinfoPanel = new MainWindowEditor.ClientInfoPanel();
            this.stagesPanel = new MainWindowEditor.StagesPanel();
            this.adminPanel = new MainWindowEditor.AdminPanel();
            this.addclientPanel = new MainWindowEditor.AddClientPanel();
            this.navbar = new MainWindowEditor.NavBar();
            this.emailPreviewControl = new MainWindowEditor.MessagePreview();
            this.timeline = new MainWindowEditor.Controls.Timeline();
            this.messageBuilder = new MainWindowEditor.MessageBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.mainsplitContainer)).BeginInit();
            this.mainsplitContainer.Panel1.SuspendLayout();
            this.mainsplitContainer.Panel2.SuspendLayout();
            this.mainsplitContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainsplitContainer
            // 
            this.mainsplitContainer.BackColor = System.Drawing.Color.White;
            this.mainsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainsplitContainer.ForeColor = System.Drawing.Color.Black;
            this.mainsplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainsplitContainer.Name = "mainsplitContainer";
            // 
            // mainsplitContainer.Panel1
            // 
            this.mainsplitContainer.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainsplitContainer.Panel1.Controls.Add(this.mainPanel);
            this.mainsplitContainer.Panel1.Controls.Add(this.adminPanel);
            this.mainsplitContainer.Panel1.Controls.Add(this.addclientPanel);
            this.mainsplitContainer.Panel1.Controls.Add(this.navbar);
            // 
            // mainsplitContainer.Panel2
            // 
            this.mainsplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.mainsplitContainer.Panel2.Controls.Add(this.emailPreviewControl);
            this.mainsplitContainer.Panel2.ForeColor = System.Drawing.Color.Black;
            this.mainsplitContainer.Size = new System.Drawing.Size(1488, 881);
            this.mainsplitContainer.SplitterDistance = 551;
            this.mainsplitContainer.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScrollMargin = new System.Drawing.Size(500, 300);
            this.mainPanel.Controls.Add(this.messageBuilder);
            this.mainPanel.Controls.Add(this.clientinfoPanel);
            this.mainPanel.Controls.Add(this.stagesPanel);
            this.mainPanel.Controls.Add(this.timeline);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(45, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(506, 881);
            this.mainPanel.TabIndex = 9;
            // 
            // clientinfoPanel
            // 
            this.clientinfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientinfoPanel.Location = new System.Drawing.Point(0, 0);
            this.clientinfoPanel.Name = "clientinfoPanel";
            this.clientinfoPanel.Size = new System.Drawing.Size(506, 326);
            this.clientinfoPanel.TabIndex = 23;
            // 
            // stagesPanel
            // 
            this.stagesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stagesPanel.Location = new System.Drawing.Point(0, 630);
            this.stagesPanel.Name = "stagesPanel";
            this.stagesPanel.Padding = new System.Windows.Forms.Padding(6);
            this.stagesPanel.Size = new System.Drawing.Size(506, 251);
            this.stagesPanel.TabIndex = 17;
            // 
            // adminPanel
            // 
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(45, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(506, 881);
            this.adminPanel.TabIndex = 26;
            // 
            // addclientPanel
            // 
            this.addclientPanel.AutoScroll = true;
            this.addclientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addclientPanel.Location = new System.Drawing.Point(45, 0);
            this.addclientPanel.Main = null;
            this.addclientPanel.Name = "addclientPanel";
            this.addclientPanel.Size = new System.Drawing.Size(506, 881);
            this.addclientPanel.TabIndex = 25;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(45, 881);
            this.navbar.TabIndex = 1;
            // 
            // emailPreviewControl
            // 
            this.emailPreviewControl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPreviewControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailPreviewControl.Location = new System.Drawing.Point(0, 0);
            this.emailPreviewControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailPreviewControl.Name = "emailPreviewControl";
            this.emailPreviewControl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.emailPreviewControl.Size = new System.Drawing.Size(933, 881);
            this.emailPreviewControl.TabIndex = 0;
            // 
            // timeline
            // 
            this.timeline.AutoScroll = true;
            this.timeline.BackColor = System.Drawing.SystemColors.Control;
            this.timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline.Location = new System.Drawing.Point(0, 0);
            this.timeline.Name = "timeline";
            this.timeline.Padding = new System.Windows.Forms.Padding(7);
            this.timeline.Size = new System.Drawing.Size(506, 630);
            this.timeline.TabIndex = 19;
            // 
            // messageBuilder
            // 
            this.messageBuilder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageBuilder.Location = new System.Drawing.Point(0, 326);
            this.messageBuilder.Name = "messageBuilder";
            this.messageBuilder.Padding = new System.Windows.Forms.Padding(7);
            this.messageBuilder.Size = new System.Drawing.Size(506, 304);
            this.messageBuilder.TabIndex = 24;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1488, 881);
            this.Controls.Add(this.mainsplitContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.mainsplitContainer.Panel1.ResumeLayout(false);
            this.mainsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainsplitContainer)).EndInit();
            this.mainsplitContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainsplitContainer;
        private MessagePreview emailPreviewControl;
        private NavBar navbar;
        private System.Windows.Forms.Panel mainPanel;
        private ClientInfoPanel clientinfoPanel;
        private StagesPanel stagesPanel;
        private AddClientPanel addclientPanel;
        private AdminPanel adminPanel;
        private MessageBuilder messageBuilder;
        private Controls.Timeline timeline;
    }
}