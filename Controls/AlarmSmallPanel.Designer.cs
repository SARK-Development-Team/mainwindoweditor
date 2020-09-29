namespace MainWindowEditor.Controls
{
    partial class AlarmSmallPanel
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
            this.submitButton = new System.Windows.Forms.Button();
            this.deciderTextBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(320, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(61, 25);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // deciderTextBox
            // 
            this.deciderTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.deciderTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deciderTextBox.FormattingEnabled = true;
            this.deciderTextBox.Items.AddRange(new object[] {
            "Morning (10:00 AM - 12:00 PM)",
            "Afternoon (12:00 PM - 2:00 PM)",
            "Midday (2:00 PM - 4:00 PM)",
            "Evening (4:00 PM - 6:00 PM)"});
            this.deciderTextBox.Location = new System.Drawing.Point(5, 5);
            this.deciderTextBox.Name = "deciderTextBox";
            this.deciderTextBox.Size = new System.Drawing.Size(143, 25);
            this.deciderTextBox.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(148, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(172, 25);
            this.dateTimePicker.TabIndex = 11;
            // 
            // AlarmSmallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.deciderTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "AlarmSmallPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(386, 35);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox deciderTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
