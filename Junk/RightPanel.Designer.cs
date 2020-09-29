namespace MainWindowEditor
{
    partial class RightPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightPanel));
            this.templatePanel = new System.Windows.Forms.Panel();
            this.templateBrowser = new System.Windows.Forms.WebBrowser();
            this.emailToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.previewTSButton = new System.Windows.Forms.ToolStripButton();
            this.saveTSButton = new System.Windows.Forms.ToolStripButton();
            this.openTSButton = new System.Windows.Forms.ToolStripButton();
            this.imagepreviewTSSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainTSSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.rightinfoTSSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.clientemailTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.templatesTSDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.customTSButton = new System.Windows.Forms.ToolStripButton();
            this.customTSSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.templatePanel.SuspendLayout();
            this.emailToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // templatePanel
            // 
            this.templatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templatePanel.AutoScroll = true;
            this.templatePanel.Controls.Add(this.emailToolStrip);
            this.templatePanel.Controls.Add(this.templateBrowser);
            this.templatePanel.Location = new System.Drawing.Point(289, 47);
            this.templatePanel.Name = "templatePanel";
            this.templatePanel.Size = new System.Drawing.Size(902, 831);
            this.templatePanel.TabIndex = 159;
            // 
            // templateBrowser
            // 
            this.templateBrowser.AllowWebBrowserDrop = global::MainWindowEditor.Properties.Settings.Default.VisibilityTrue;
            this.templateBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateBrowser.IsWebBrowserContextMenuEnabled = global::MainWindowEditor.Properties.Settings.Default.VisibilityTrue;
            this.templateBrowser.Location = new System.Drawing.Point(0, 0);
            this.templateBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.templateBrowser.Name = "templateBrowser";
            this.templateBrowser.Size = new System.Drawing.Size(902, 831);
            this.templateBrowser.TabIndex = 158;
            this.templateBrowser.Visible = global::MainWindowEditor.Properties.Settings.Default.VisibilityTrue;
            // 
            // emailToolStrip
            // 
            this.emailToolStrip.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailToolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.emailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleTSLabel,
            this.templatesTSDropDown,
            this.customTSButton,
            this.customTSSeparator,
            this.openTSButton,
            this.saveTSButton,
            this.mainTSSeparator,
            this.previewTSButton,
            this.imagepreviewTSSeparator,
            this.rightinfoTSSeparator,
            this.clientemailTSLabel});
            this.emailToolStrip.Location = new System.Drawing.Point(0, 0);
            this.emailToolStrip.Name = "emailToolStrip";
            this.emailToolStrip.Size = new System.Drawing.Size(902, 57);
            this.emailToolStrip.TabIndex = 159;
            this.emailToolStrip.Text = "Email Template Tools";
            // 
            // titleTSLabel
            // 
            this.titleTSLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.titleTSLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.titleTSLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTSLabel.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.titleTSLabel.Name = "titleTSLabel";
            this.titleTSLabel.Size = new System.Drawing.Size(82, 54);
            this.titleTSLabel.Text = "Email Title";
            // 
            // previewTSButton
            // 
            this.previewTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.previewTSButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTSButton.Image = ((System.Drawing.Image)(resources.GetObject("previewTSButton.Image")));
            this.previewTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewTSButton.Name = "previewTSButton";
            this.previewTSButton.Size = new System.Drawing.Size(68, 54);
            this.previewTSButton.Text = "Preview";
            // 
            // saveTSButton
            // 
            this.saveTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTSButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTSButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTSButton.Image")));
            this.saveTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTSButton.Name = "saveTSButton";
            this.saveTSButton.Size = new System.Drawing.Size(54, 54);
            this.saveTSButton.Text = "&Save";
            // 
            // openTSButton
            // 
            this.openTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTSButton.Image = ((System.Drawing.Image)(resources.GetObject("openTSButton.Image")));
            this.openTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTSButton.Name = "openTSButton";
            this.openTSButton.Size = new System.Drawing.Size(54, 54);
            this.openTSButton.Text = "&Open";
            // 
            // imagepreviewTSSeparator
            // 
            this.imagepreviewTSSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.imagepreviewTSSeparator.Name = "imagepreviewTSSeparator";
            this.imagepreviewTSSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // mainTSSeparator
            // 
            this.mainTSSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.mainTSSeparator.Name = "mainTSSeparator";
            this.mainTSSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // rightinfoTSSeparator
            // 
            this.rightinfoTSSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rightinfoTSSeparator.Margin = new System.Windows.Forms.Padding(15);
            this.rightinfoTSSeparator.Name = "rightinfoTSSeparator";
            this.rightinfoTSSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // clientemailTSLabel
            // 
            this.clientemailTSLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clientemailTSLabel.Name = "clientemailTSLabel";
            this.clientemailTSLabel.Size = new System.Drawing.Size(129, 54);
            this.clientemailTSLabel.Text = "email@email.com";
            // 
            // templatesTSDropDown
            // 
            this.templatesTSDropDown.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatesTSDropDown.Image = ((System.Drawing.Image)(resources.GetObject("templatesTSDropDown.Image")));
            this.templatesTSDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.templatesTSDropDown.Name = "templatesTSDropDown";
            this.templatesTSDropDown.Size = new System.Drawing.Size(130, 54);
            this.templatesTSDropDown.Text = "Templates";
            // 
            // customTSButton
            // 
            this.customTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customTSButton.Image = ((System.Drawing.Image)(resources.GetObject("customTSButton.Image")));
            this.customTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customTSButton.Name = "customTSButton";
            this.customTSButton.Size = new System.Drawing.Size(54, 54);
            this.customTSButton.Text = "Custom";
            // 
            // customTSSeparator
            // 
            this.customTSSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.customTSSeparator.Name = "customTSSeparator";
            this.customTSSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // RightPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.templatePanel);
            this.Name = "RightPanel";
            this.Size = new System.Drawing.Size(1514, 964);
            this.templatePanel.ResumeLayout(false);
            this.templatePanel.PerformLayout();
            this.emailToolStrip.ResumeLayout(false);
            this.emailToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel templatePanel;
        private System.Windows.Forms.WebBrowser templateBrowser;
        private System.Windows.Forms.ToolStrip emailToolStrip;
        private System.Windows.Forms.ToolStripLabel titleTSLabel;
        private System.Windows.Forms.ToolStripButton saveTSButton;
        private System.Windows.Forms.ToolStripButton openTSButton;
        private System.Windows.Forms.ToolStripSeparator mainTSSeparator;
        private System.Windows.Forms.ToolStripButton previewTSButton;
        private System.Windows.Forms.ToolStripSeparator imagepreviewTSSeparator;
        private System.Windows.Forms.ToolStripSeparator rightinfoTSSeparator;
        private System.Windows.Forms.ToolStripLabel clientemailTSLabel;
        private System.Windows.Forms.ToolStripDropDownButton templatesTSDropDown;
        private System.Windows.Forms.ToolStripButton customTSButton;
        private System.Windows.Forms.ToolStripSeparator customTSSeparator;
    }
}
