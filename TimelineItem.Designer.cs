namespace MainWindowEditor
{
    partial class TimelineItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineItem));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.dotdotdotButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconCircle = new MainWindowEditor.IconCircle();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.authorLabel);
            this.bottomPanel.Controls.Add(this.dotdotdotButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(68, 69);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(291, 17);
            this.bottomPanel.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(100, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(171, 17);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "authorLabel";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dotdotdotButton
            // 
            this.dotdotdotButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dotdotdotButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.ellipsis;
            this.dotdotdotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dotdotdotButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.dotdotdotButton.FlatAppearance.BorderSize = 0;
            this.dotdotdotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotdotdotButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotdotdotButton.Location = new System.Drawing.Point(271, 0);
            this.dotdotdotButton.Name = "dotdotdotButton";
            this.dotdotdotButton.Size = new System.Drawing.Size(20, 17);
            this.dotdotdotButton.TabIndex = 1;
            this.dotdotdotButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dotdotdotButton.UseVisualStyleBackColor = false;
            this.dotdotdotButton.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.topPanel.Controls.Add(this.descriptionTextBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(68, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(5);
            this.topPanel.Size = new System.Drawing.Size(291, 69);
            this.topPanel.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descriptionTextBox.Location = new System.Drawing.Point(5, 5);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(281, 59);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.iconCircle);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Padding = new System.Windows.Forms.Padding(5);
            this.iconPanel.Size = new System.Drawing.Size(68, 86);
            this.iconPanel.TabIndex = 2;
            // 
            // iconCircle
            // 
            this.iconCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconCircle.BackgroundImage")));
            this.iconCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconCircle.Location = new System.Drawing.Point(5, 5);
            this.iconCircle.Name = "iconCircle";
            this.iconCircle.Size = new System.Drawing.Size(58, 76);
            this.iconCircle.TabIndex = 0;
            // 
            // TimelineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.iconPanel);
            this.Name = "TimelineItem";
            this.Size = new System.Drawing.Size(359, 86);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button dotdotdotButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel iconPanel;
        private IconCircle iconCircle;
    }
}
