namespace MainWindowEditor.Controls
{
    partial class IconLabelButton
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
            this.iconLabel = new System.Windows.Forms.Label();
            this.icon = new MainWindowEditor.IconCircle();
            this.SuspendLayout();
            // 
            // iconLabel
            // 
            this.iconLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLabel.Location = new System.Drawing.Point(0, 80);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(63, 13);
            this.iconLabel.TabIndex = 1;
            this.iconLabel.Text = "Label Text";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Padding = new System.Windows.Forms.Padding(2);
            this.icon.Size = new System.Drawing.Size(63, 80);
            this.icon.TabIndex = 2;
            // 
            // IconLabelButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.icon);
            this.Controls.Add(this.iconLabel);
            this.Name = "IconLabelButton";
            this.Size = new System.Drawing.Size(63, 93);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label iconLabel;
        private IconCircle icon;
    }
}
