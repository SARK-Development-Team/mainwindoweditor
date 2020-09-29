namespace MainWindowEditor
{
    partial class EmailPanel
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sendIconCircle = new MainWindowEditor.IconCircle();
            this.backIconCircle = new MainWindowEditor.IconCircle();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.emailTextBox);
            this.topPanel.Controls.Add(this.nameTextBox);
            this.topPanel.Controls.Add(this.sendIconCircle);
            this.topPanel.Controls.Add(this.backIconCircle);
            this.topPanel.Controls.Add(this.emailLabel);
            this.topPanel.Controls.Add(this.nameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(633, 76);
            this.topPanel.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(127, 46);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(386, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(127, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(386, 21);
            this.nameTextBox.TabIndex = 5;
            // 
            // sendIconCircle
            // 
            this.sendIconCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendIconCircle.Location = new System.Drawing.Point(563, 17);
            this.sendIconCircle.Name = "sendIconCircle";
            this.sendIconCircle.Padding = new System.Windows.Forms.Padding(7);
            this.sendIconCircle.Size = new System.Drawing.Size(45, 45);
            this.sendIconCircle.TabIndex = 4;
            // 
            // backIconCircle
            // 
            this.backIconCircle.Location = new System.Drawing.Point(13, 17);
            this.backIconCircle.Name = "backIconCircle";
            this.backIconCircle.Padding = new System.Windows.Forms.Padding(7);
            this.backIconCircle.Size = new System.Drawing.Size(43, 43);
            this.backIconCircle.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(85, 49);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(85, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Window;
            this.bottomPanel.Controls.Add(this.emailRichTextBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 76);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(25);
            this.bottomPanel.Size = new System.Drawing.Size(633, 484);
            this.bottomPanel.TabIndex = 1;
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.AcceptsTab = true;
            this.emailRichTextBox.AutoWordSelection = true;
            this.emailRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailRichTextBox.EnableAutoDragDrop = true;
            this.emailRichTextBox.Location = new System.Drawing.Point(25, 25);
            this.emailRichTextBox.Name = "emailRichTextBox";
            this.emailRichTextBox.Size = new System.Drawing.Size(583, 434);
            this.emailRichTextBox.TabIndex = 0;
            this.emailRichTextBox.Text = "";
            // 
            // EmailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "EmailPanel";
            this.Size = new System.Drawing.Size(633, 560);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private IconCircle backIconCircle;
        private IconCircle sendIconCircle;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}
