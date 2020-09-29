namespace MainWindowEditor
{
    partial class EmailStage
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
            this.sendselfButton = new System.Windows.Forms.Button();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.backIconCircle = new MainWindowEditor.IconCircle();
            this.iconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendemailButton
            // 
            this.sendemailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendemailButton.BackColor = System.Drawing.Color.LightGreen;
            this.sendemailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendemailButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendemailButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.sendemailButton.Location = new System.Drawing.Point(186, 17);
            this.sendemailButton.Name = "sendemailButton";
            this.sendemailButton.Size = new System.Drawing.Size(210, 50);
            this.sendemailButton.TabIndex = 1;
            this.sendemailButton.Text = "Send Email";
            this.sendemailButton.UseVisualStyleBackColor = false;
            // 
            // sendselfButton
            // 
            this.sendselfButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendselfButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.sendselfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendselfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendselfButton.ForeColor = System.Drawing.Color.White;
            this.sendselfButton.Location = new System.Drawing.Point(186, 73);
            this.sendselfButton.Name = "sendselfButton";
            this.sendselfButton.Size = new System.Drawing.Size(210, 36);
            this.sendselfButton.TabIndex = 2;
            this.sendselfButton.Text = "Send to Self";
            this.sendselfButton.UseVisualStyleBackColor = false;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.backIconCircle);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Padding = new System.Windows.Forms.Padding(20);
            this.iconPanel.Size = new System.Drawing.Size(107, 123);
            this.iconPanel.TabIndex = 3;
            // 
            // backIconCircle
            // 
            this.backIconCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backIconCircle.Location = new System.Drawing.Point(20, 20);
            this.backIconCircle.Name = "backIconCircle";
            this.backIconCircle.Padding = new System.Windows.Forms.Padding(2);
            this.backIconCircle.Size = new System.Drawing.Size(67, 83);
            this.backIconCircle.TabIndex = 1;
            // 
            // emailStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.iconPanel);
            this.Controls.Add(this.sendselfButton);
            this.Controls.Add(this.sendemailButton);
            this.Name = "emailStage";
            this.Size = new System.Drawing.Size(416, 123);
            this.iconPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sendemailButton;
        private System.Windows.Forms.Button sendselfButton;
        private System.Windows.Forms.Panel iconPanel;
        private IconCircle backIconCircle;
    }
}
