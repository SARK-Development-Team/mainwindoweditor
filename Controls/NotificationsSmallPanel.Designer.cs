namespace MainWindowEditor.Controls
{
    partial class NotificationsSmallPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.notificationsPanel = new System.Windows.Forms.Panel();
            this.sampleTextBox = new System.Windows.Forms.TextBox();
            this.sample2TextBox = new System.Windows.Forms.TextBox();
            this.notificationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Notifications";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // notificationsPanel
            // 
            this.notificationsPanel.AutoSize = true;
            this.notificationsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notificationsPanel.Controls.Add(this.sample2TextBox);
            this.notificationsPanel.Controls.Add(this.sampleTextBox);
            this.notificationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsPanel.Location = new System.Drawing.Point(0, 17);
            this.notificationsPanel.Name = "notificationsPanel";
            this.notificationsPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.notificationsPanel.Size = new System.Drawing.Size(160, 86);
            this.notificationsPanel.TabIndex = 1;
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sampleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sampleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sampleTextBox.Location = new System.Drawing.Point(0, 5);
            this.sampleTextBox.Multiline = true;
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.ReadOnly = true;
            this.sampleTextBox.Size = new System.Drawing.Size(160, 35);
            this.sampleTextBox.TabIndex = 4;
            this.sampleTextBox.Text = "No notifications were found for this client.";
            // 
            // sample2TextBox
            // 
            this.sample2TextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.sample2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sample2TextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sample2TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sample2TextBox.Location = new System.Drawing.Point(0, 40);
            this.sample2TextBox.Multiline = true;
            this.sample2TextBox.Name = "sample2TextBox";
            this.sample2TextBox.ReadOnly = true;
            this.sample2TextBox.Size = new System.Drawing.Size(160, 29);
            this.sample2TextBox.TabIndex = 5;
            // 
            // NotificationsSmallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notificationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "NotificationsSmallPanel";
            this.Size = new System.Drawing.Size(160, 103);
            this.notificationsPanel.ResumeLayout(false);
            this.notificationsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel notificationsPanel;
        private System.Windows.Forms.TextBox sampleTextBox;
        private System.Windows.Forms.TextBox sample2TextBox;
    }
}
