namespace MainWindowEditor.Controls
{
    partial class Timeline
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
            this.commentsPanel = new System.Windows.Forms.Panel();
            this.addcommentTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.addcommentButton = new MainWindowEditor.IconCircle();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.timelineItem1 = new MainWindowEditor.TimelineItem();
            this.commentsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentsPanel
            // 
            this.commentsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.commentsPanel.Controls.Add(this.addcommentTextBox);
            this.commentsPanel.Controls.Add(this.addcommentButton);
            this.commentsPanel.Controls.Add(this.filterButton);
            this.commentsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentsPanel.Location = new System.Drawing.Point(0, 537);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.commentsPanel.Size = new System.Drawing.Size(497, 37);
            this.commentsPanel.TabIndex = 6;
            // 
            // addcommentTextBox
            // 
            this.addcommentTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addcommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addcommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addcommentTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcommentTextBox.ForeColor = System.Drawing.Color.Black;
            this.addcommentTextBox.Location = new System.Drawing.Point(5, 5);
            this.addcommentTextBox.Multiline = true;
            this.addcommentTextBox.Name = "addcommentTextBox";
            this.addcommentTextBox.Size = new System.Drawing.Size(425, 27);
            this.addcommentTextBox.TabIndex = 10;
            this.addcommentTextBox.Text = "Please enter a note here...";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.filterButton.BackgroundImage = global::MainWindowEditor.Properties.Resources.filter;
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.filterButton.FlatAppearance.BorderSize = 5;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.filterButton.Location = new System.Drawing.Point(462, 5);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(30, 27);
            this.filterButton.TabIndex = 7;
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // addcommentButton
            // 
            this.addcommentButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addcommentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addcommentButton.Location = new System.Drawing.Point(430, 5);
            this.addcommentButton.Name = "addcommentButton";
            this.addcommentButton.Padding = new System.Windows.Forms.Padding(10);
            this.addcommentButton.Size = new System.Drawing.Size(32, 27);
            this.addcommentButton.TabIndex = 9;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(497, 32);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(497, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Timeline";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.itemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemsPanel.Controls.Add(this.timelineItem1);
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemsPanel.Location = new System.Drawing.Point(0, 32);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.itemsPanel.Size = new System.Drawing.Size(497, 505);
            this.itemsPanel.TabIndex = 250;
            // 
            // timelineItem1
            // 
            this.timelineItem1.BackColor = System.Drawing.Color.Transparent;
            this.timelineItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timelineItem1.Item = null;
            this.timelineItem1.Location = new System.Drawing.Point(5, 10);
            this.timelineItem1.Name = "timelineItem1";
            this.timelineItem1.Size = new System.Drawing.Size(487, 57);
            this.timelineItem1.TabIndex = 2;
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.commentsPanel);
            this.Name = "Timeline";
            this.Size = new System.Drawing.Size(497, 574);
            this.commentsPanel.ResumeLayout(false);
            this.commentsPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.itemsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel commentsPanel;
        private System.Windows.Forms.Button filterButton;
        private IconCircle addcommentButton;
        private System.Windows.Forms.TextBox addcommentTextBox;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel itemsPanel;
        private TimelineItem timelineItem1;
    }
}
