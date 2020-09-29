namespace MainWindowEditor
{
    partial class RunStage
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
            this.sendemailButton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.commsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.plusLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendemailButton
            // 
            this.sendemailButton.BackColor = System.Drawing.Color.LightGreen;
            this.sendemailButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendemailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendemailButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendemailButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.sendemailButton.Location = new System.Drawing.Point(348, 0);
            this.sendemailButton.Name = "sendemailButton";
            this.sendemailButton.Size = new System.Drawing.Size(73, 140);
            this.sendemailButton.TabIndex = 2;
            this.sendemailButton.Text = "Run";
            this.sendemailButton.UseVisualStyleBackColor = false;
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.Controls.Add(this.plusLabel);
            this.infoPanel.Controls.Add(this.actionListBox);
            this.infoPanel.Controls.Add(this.explanationTextBox);
            this.infoPanel.Controls.Add(this.commsCheckedListBox);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(348, 140);
            this.infoPanel.TabIndex = 3;
            // 
            // actionListBox
            // 
            this.actionListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.ItemHeight = 17;
            this.actionListBox.Items.AddRange(new object[] {
            "Send Introduction",
            "Send Checklist"});
            this.actionListBox.Location = new System.Drawing.Point(18, 45);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(154, 72);
            this.actionListBox.TabIndex = 9;
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explanationTextBox.Location = new System.Drawing.Point(18, 19);
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(311, 20);
            this.explanationTextBox.TabIndex = 8;
            // 
            // commsCheckedListBox
            // 
            this.commsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commsCheckedListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commsCheckedListBox.FormattingEnabled = true;
            this.commsCheckedListBox.Items.AddRange(new object[] {
            "Email",
            "Text"});
            this.commsCheckedListBox.Location = new System.Drawing.Point(231, 45);
            this.commsCheckedListBox.Name = "commsCheckedListBox";
            this.commsCheckedListBox.Size = new System.Drawing.Size(98, 76);
            this.commsCheckedListBox.TabIndex = 7;
            // 
            // plusLabel
            // 
            this.plusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.plusLabel.Location = new System.Drawing.Point(189, 69);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(26, 25);
            this.plusLabel.TabIndex = 10;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.sendemailButton);
            this.Name = "runStage";
            this.Size = new System.Drawing.Size(421, 140);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendemailButton;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.CheckedListBox commsCheckedListBox;
        private System.Windows.Forms.Label plusLabel;
    }
}
