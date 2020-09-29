namespace MainWindowEditor
{
    partial class StagesPanel
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.paddingPanel = new System.Windows.Forms.Panel();
            this.stagesBar = new MainWindowEditor.StagesBar();
            this.runStage = new MainWindowEditor.RunStage();
            this.emailStage = new MainWindowEditor.EmailStage();
            this.titlePanel.SuspendLayout();
            this.paddingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(518, 28);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(518, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Stages";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paddingPanel.Controls.Add(this.stagesBar);
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 28);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.paddingPanel.Size = new System.Drawing.Size(518, 55);
            this.paddingPanel.TabIndex = 9;
            // 
            // stagesBar
            // 
            this.stagesBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(194)))));
            this.stagesBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stagesBar.Location = new System.Drawing.Point(0, 5);
            this.stagesBar.Margin = new System.Windows.Forms.Padding(0);
            this.stagesBar.Name = "stagesBar";
            this.stagesBar.Size = new System.Drawing.Size(518, 50);
            this.stagesBar.TabIndex = 8;
            // 
            // runStage
            // 
            this.runStage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.runStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runStage.Location = new System.Drawing.Point(0, 83);
            this.runStage.Margin = new System.Windows.Forms.Padding(0);
            this.runStage.Name = "runStage";
            this.runStage.Size = new System.Drawing.Size(518, 138);
            this.runStage.TabIndex = 11;
            // 
            // emailStage
            // 
            this.emailStage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailStage.Location = new System.Drawing.Point(0, 83);
            this.emailStage.Name = "emailStage";
            this.emailStage.Size = new System.Drawing.Size(518, 138);
            this.emailStage.TabIndex = 12;
            this.emailStage.Visible = false;
            // 
            // StagesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailStage);
            this.Controls.Add(this.runStage);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "StagesPanel";
            this.Size = new System.Drawing.Size(518, 221);
            this.titlePanel.ResumeLayout(false);
            this.paddingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel paddingPanel;
        private StagesBar stagesBar;
        private RunStage runStage;
        private System.Windows.Forms.Label titleLabel;
        private EmailStage emailStage;
    }
}
