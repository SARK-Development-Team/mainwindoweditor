namespace MainWindowEditor
{
    partial class MessageBuilder
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.clientpropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.previewButton = new System.Windows.Forms.Button();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.previewButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(5, 334);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.actionPanel.Size = new System.Drawing.Size(524, 71);
            this.actionPanel.TabIndex = 0;
            // 
            // clientpropertyGrid
            // 
            this.clientpropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientpropertyGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientpropertyGrid.Location = new System.Drawing.Point(5, 5);
            this.clientpropertyGrid.Name = "clientpropertyGrid";
            this.clientpropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.clientpropertyGrid.Size = new System.Drawing.Size(524, 329);
            this.clientpropertyGrid.TabIndex = 1;
            // 
            // previewButton
            // 
            this.previewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewButton.Location = new System.Drawing.Point(30, 20);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(464, 31);
            this.previewButton.TabIndex = 0;
            this.previewButton.Text = "Preview Changes";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // MessageBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.clientpropertyGrid);
            this.Controls.Add(this.actionPanel);
            this.Name = "MessageBuilder";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(534, 410);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.PropertyGrid clientpropertyGrid;
    }
}
