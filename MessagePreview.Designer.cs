namespace MainWindowEditor
{
    partial class MessagePreview
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
            this.emailinfoPanel = new System.Windows.Forms.Panel();
            this.smstoTextBox = new System.Windows.Forms.TextBox();
            this.smsfromLabel = new System.Windows.Forms.Label();
            this.smstoLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.attachmentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.attachmentsLabel = new System.Windows.Forms.Label();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.ccLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.emailouterPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.emailwebBrowser = new System.Windows.Forms.WebBrowser();
            this.smsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailinfoPanel.SuspendLayout();
            this.emailouterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailinfoPanel
            // 
            this.emailinfoPanel.AutoScroll = true;
            this.emailinfoPanel.AutoScrollMinSize = new System.Drawing.Size(600, 0);
            this.emailinfoPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailinfoPanel.Controls.Add(this.smstoTextBox);
            this.emailinfoPanel.Controls.Add(this.smsfromLabel);
            this.emailinfoPanel.Controls.Add(this.smstoLabel);
            this.emailinfoPanel.Controls.Add(this.subjectTextBox);
            this.emailinfoPanel.Controls.Add(this.subjectLabel);
            this.emailinfoPanel.Controls.Add(this.attachmentsCheckedListBox);
            this.emailinfoPanel.Controls.Add(this.addButton);
            this.emailinfoPanel.Controls.Add(this.attachmentsLabel);
            this.emailinfoPanel.Controls.Add(this.ccTextBox);
            this.emailinfoPanel.Controls.Add(this.ccLabel);
            this.emailinfoPanel.Controls.Add(this.toTextBox);
            this.emailinfoPanel.Controls.Add(this.fromLabel);
            this.emailinfoPanel.Controls.Add(this.toLabel);
            this.emailinfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailinfoPanel.Location = new System.Drawing.Point(0, 10);
            this.emailinfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.emailinfoPanel.Name = "emailinfoPanel";
            this.emailinfoPanel.Size = new System.Drawing.Size(744, 196);
            this.emailinfoPanel.TabIndex = 1;
            // 
            // smstoTextBox
            // 
            this.smstoTextBox.Location = new System.Drawing.Point(60, 155);
            this.smstoTextBox.Name = "smstoTextBox";
            this.smstoTextBox.Size = new System.Drawing.Size(230, 25);
            this.smstoTextBox.TabIndex = 28;
            // 
            // smsfromLabel
            // 
            this.smsfromLabel.AutoSize = true;
            this.smsfromLabel.Location = new System.Drawing.Point(29, 126);
            this.smsfromLabel.Name = "smsfromLabel";
            this.smsfromLabel.Size = new System.Drawing.Size(132, 17);
            this.smsfromLabel.TabIndex = 27;
            this.smsfromLabel.Text = "From: (408) 262-9190";
            // 
            // smstoLabel
            // 
            this.smstoLabel.AutoSize = true;
            this.smstoLabel.Location = new System.Drawing.Point(29, 155);
            this.smstoLabel.Name = "smstoLabel";
            this.smstoLabel.Size = new System.Drawing.Size(25, 17);
            this.smstoLabel.TabIndex = 26;
            this.smstoLabel.Text = "To:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(364, 39);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(337, 25);
            this.subjectTextBox.TabIndex = 25;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(361, 19);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(53, 17);
            this.subjectLabel.TabIndex = 24;
            this.subjectLabel.Text = "Subject:";
            // 
            // attachmentsCheckedListBox
            // 
            this.attachmentsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsCheckedListBox.FormattingEnabled = true;
            this.attachmentsCheckedListBox.Location = new System.Drawing.Point(384, 90);
            this.attachmentsCheckedListBox.Name = "attachmentsCheckedListBox";
            this.attachmentsCheckedListBox.ScrollAlwaysVisible = true;
            this.attachmentsCheckedListBox.Size = new System.Drawing.Size(259, 44);
            this.attachmentsCheckedListBox.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(649, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(52, 44);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // attachmentsLabel
            // 
            this.attachmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsLabel.AutoSize = true;
            this.attachmentsLabel.Location = new System.Drawing.Point(381, 70);
            this.attachmentsLabel.Name = "attachmentsLabel";
            this.attachmentsLabel.Size = new System.Drawing.Size(44, 17);
            this.attachmentsLabel.TabIndex = 20;
            this.attachmentsLabel.Text = "Attach";
            // 
            // ccTextBox
            // 
            this.ccTextBox.Location = new System.Drawing.Point(60, 77);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(230, 25);
            this.ccTextBox.TabIndex = 15;
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Location = new System.Drawing.Point(27, 77);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(27, 17);
            this.ccLabel.TabIndex = 13;
            this.ccLabel.Text = "CC:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(60, 46);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(230, 25);
            this.toTextBox.TabIndex = 12;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(29, 18);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(179, 17);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "From: wc@sarkinsurance.com";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(29, 46);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 17);
            this.toLabel.TabIndex = 10;
            this.toLabel.Text = "To:";
            // 
            // emailouterPanel
            // 
            this.emailouterPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailouterPanel.Controls.Add(this.emailinfoPanel);
            this.emailouterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailouterPanel.Location = new System.Drawing.Point(10, 0);
            this.emailouterPanel.Name = "emailouterPanel";
            this.emailouterPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.emailouterPanel.Size = new System.Drawing.Size(744, 216);
            this.emailouterPanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 216);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.emailwebBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.smsRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(744, 409);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.TabIndex = 3;
            // 
            // emailwebBrowser
            // 
            this.emailwebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailwebBrowser.Location = new System.Drawing.Point(0, 0);
            this.emailwebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailwebBrowser.Name = "emailwebBrowser";
            this.emailwebBrowser.Size = new System.Drawing.Size(606, 409);
            this.emailwebBrowser.TabIndex = 10;
            // 
            // smsRichTextBox
            // 
            this.smsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smsRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.smsRichTextBox.Name = "smsRichTextBox";
            this.smsRichTextBox.ReadOnly = true;
            this.smsRichTextBox.Size = new System.Drawing.Size(134, 409);
            this.smsRichTextBox.TabIndex = 10;
            this.smsRichTextBox.Text = "SMS template will be built here.";
            // 
            // MessagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.emailouterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessagePreview";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Size = new System.Drawing.Size(764, 625);
            this.emailinfoPanel.ResumeLayout(false);
            this.emailinfoPanel.PerformLayout();
            this.emailouterPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel emailinfoPanel;
        private System.Windows.Forms.TextBox smstoTextBox;
        private System.Windows.Forms.Label smsfromLabel;
        private System.Windows.Forms.Label smstoLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.CheckedListBox attachmentsCheckedListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label attachmentsLabel;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Panel emailouterPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser emailwebBrowser;
        private System.Windows.Forms.RichTextBox smsRichTextBox;
    }
}
