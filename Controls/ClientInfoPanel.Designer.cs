namespace MainWindowEditor
{
    partial class ClientInfoPanel
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
            this.leftinfoPanel = new System.Windows.Forms.Panel();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.allbuttonsPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.updateinfoButton = new System.Windows.Forms.Button();
            this.companytypeLabel = new System.Windows.Forms.Label();
            this.dbaTextBox = new System.Windows.Forms.TextBox();
            this.dbaLabel = new System.Windows.Forms.Label();
            this.MCTextBox = new System.Windows.Forms.TextBox();
            this.MCLabel = new System.Windows.Forms.Label();
            this.dateaddedTextBox = new System.Windows.Forms.TextBox();
            this.dateaddedLabel = new System.Windows.Forms.Label();
            this.dotLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.trucksTextBox = new System.Windows.Forms.TextBox();
            this.driversTextBox = new System.Windows.Forms.TextBox();
            this.trucksLabel = new System.Windows.Forms.Label();
            this.driversLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.notificationsSmallPanel = new MainWindowEditor.Controls.NotificationsSmallPanel();
            this.notinterestButton = new MainWindowEditor.Controls.IconLabelButton();
            this.alarmButton = new MainWindowEditor.Controls.IconLabelButton();
            this.transferButton = new MainWindowEditor.Controls.IconLabelButton();
            this.smsButton = new MainWindowEditor.Controls.IconLabelButton();
            this.emailButton = new MainWindowEditor.Controls.IconLabelButton();
            this.deleteButton = new MainWindowEditor.Controls.IconLabelButton();
            this.leftinfoPanel.SuspendLayout();
            this.allbuttonsPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftinfoPanel
            // 
            this.leftinfoPanel.AutoScroll = true;
            this.leftinfoPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftinfoPanel.Controls.Add(this.notificationsSmallPanel);
            this.leftinfoPanel.Controls.Add(this.notificationsButton);
            this.leftinfoPanel.Controls.Add(this.allbuttonsPanel);
            this.leftinfoPanel.Controls.Add(this.updateinfoButton);
            this.leftinfoPanel.Controls.Add(this.companytypeLabel);
            this.leftinfoPanel.Controls.Add(this.dbaTextBox);
            this.leftinfoPanel.Controls.Add(this.dbaLabel);
            this.leftinfoPanel.Controls.Add(this.MCTextBox);
            this.leftinfoPanel.Controls.Add(this.MCLabel);
            this.leftinfoPanel.Controls.Add(this.dateaddedTextBox);
            this.leftinfoPanel.Controls.Add(this.dateaddedLabel);
            this.leftinfoPanel.Controls.Add(this.dotLabel);
            this.leftinfoPanel.Controls.Add(this.addressTextBox);
            this.leftinfoPanel.Controls.Add(this.addressLabel);
            this.leftinfoPanel.Controls.Add(this.trucksTextBox);
            this.leftinfoPanel.Controls.Add(this.driversTextBox);
            this.leftinfoPanel.Controls.Add(this.trucksLabel);
            this.leftinfoPanel.Controls.Add(this.driversLabel);
            this.leftinfoPanel.Controls.Add(this.phoneTextBox);
            this.leftinfoPanel.Controls.Add(this.emailTextBox);
            this.leftinfoPanel.Controls.Add(this.nameTextBox);
            this.leftinfoPanel.Controls.Add(this.phoneLabel);
            this.leftinfoPanel.Controls.Add(this.emailLabel);
            this.leftinfoPanel.Controls.Add(this.nameLabel);
            this.leftinfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftinfoPanel.Location = new System.Drawing.Point(0, 0);
            this.leftinfoPanel.Name = "leftinfoPanel";
            this.leftinfoPanel.Size = new System.Drawing.Size(454, 329);
            this.leftinfoPanel.TabIndex = 245;
            // 
            // notificationsButton
            // 
            this.notificationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationsButton.Enabled = false;
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsButton.Location = new System.Drawing.Point(279, 20);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Size = new System.Drawing.Size(146, 26);
            this.notificationsButton.TabIndex = 267;
            this.notificationsButton.Text = "Notifications: 0";
            this.notificationsButton.UseVisualStyleBackColor = true;
            // 
            // allbuttonsPanel
            // 
            this.allbuttonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.allbuttonsPanel.Controls.Add(this.buttonsPanel);
            this.allbuttonsPanel.Controls.Add(this.adminPanel);
            this.allbuttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allbuttonsPanel.Location = new System.Drawing.Point(0, 267);
            this.allbuttonsPanel.Name = "allbuttonsPanel";
            this.allbuttonsPanel.Size = new System.Drawing.Size(454, 62);
            this.allbuttonsPanel.TabIndex = 266;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.notinterestButton);
            this.buttonsPanel.Controls.Add(this.alarmButton);
            this.buttonsPanel.Controls.Add(this.transferButton);
            this.buttonsPanel.Controls.Add(this.smsButton);
            this.buttonsPanel.Controls.Add(this.emailButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonsPanel.Size = new System.Drawing.Size(362, 62);
            this.buttonsPanel.TabIndex = 266;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.MistyRose;
            this.adminPanel.Controls.Add(this.deleteButton);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminPanel.Location = new System.Drawing.Point(362, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.adminPanel.Size = new System.Drawing.Size(92, 62);
            this.adminPanel.TabIndex = 265;
            // 
            // updateinfoButton
            // 
            this.updateinfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateinfoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateinfoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateinfoButton.Location = new System.Drawing.Point(278, 219);
            this.updateinfoButton.Name = "updateinfoButton";
            this.updateinfoButton.Size = new System.Drawing.Size(147, 35);
            this.updateinfoButton.TabIndex = 265;
            this.updateinfoButton.Text = "Update";
            this.updateinfoButton.UseVisualStyleBackColor = false;
            // 
            // companytypeLabel
            // 
            this.companytypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companytypeLabel.AutoSize = true;
            this.companytypeLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companytypeLabel.Location = new System.Drawing.Point(276, 87);
            this.companytypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companytypeLabel.Name = "companytypeLabel";
            this.companytypeLabel.Size = new System.Drawing.Size(35, 15);
            this.companytypeLabel.TabIndex = 259;
            this.companytypeLabel.Text = "Type:";
            // 
            // dbaTextBox
            // 
            this.dbaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dbaTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbaTextBox.Location = new System.Drawing.Point(64, 116);
            this.dbaTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dbaTextBox.Name = "dbaTextBox";
            this.dbaTextBox.Size = new System.Drawing.Size(176, 23);
            this.dbaTextBox.TabIndex = 258;
            this.dbaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbaLabel
            // 
            this.dbaLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbaLabel.Location = new System.Drawing.Point(15, 119);
            this.dbaLabel.Margin = new System.Windows.Forms.Padding(2);
            this.dbaLabel.Name = "dbaLabel";
            this.dbaLabel.Size = new System.Drawing.Size(38, 18);
            this.dbaLabel.TabIndex = 257;
            this.dbaLabel.Text = "DBA";
            this.dbaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MCTextBox
            // 
            this.MCTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MCTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCTextBox.Location = new System.Drawing.Point(64, 54);
            this.MCTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MCTextBox.Name = "MCTextBox";
            this.MCTextBox.ReadOnly = true;
            this.MCTextBox.Size = new System.Drawing.Size(120, 23);
            this.MCTextBox.TabIndex = 256;
            this.MCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MCLabel
            // 
            this.MCLabel.AutoSize = true;
            this.MCLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCLabel.Location = new System.Drawing.Point(17, 57);
            this.MCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(36, 15);
            this.MCLabel.TabIndex = 255;
            this.MCLabel.Text = "MC #";
            // 
            // dateaddedTextBox
            // 
            this.dateaddedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateaddedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dateaddedTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateaddedTextBox.Location = new System.Drawing.Point(279, 190);
            this.dateaddedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateaddedTextBox.Name = "dateaddedTextBox";
            this.dateaddedTextBox.ReadOnly = true;
            this.dateaddedTextBox.Size = new System.Drawing.Size(146, 23);
            this.dateaddedTextBox.TabIndex = 254;
            this.dateaddedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateaddedLabel
            // 
            this.dateaddedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateaddedLabel.AutoSize = true;
            this.dateaddedLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateaddedLabel.Location = new System.Drawing.Point(275, 172);
            this.dateaddedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateaddedLabel.Name = "dateaddedLabel";
            this.dateaddedLabel.Size = new System.Drawing.Size(69, 15);
            this.dateaddedLabel.TabIndex = 253;
            this.dateaddedLabel.Text = "Date Added";
            // 
            // dotLabel
            // 
            this.dotLabel.AutoSize = true;
            this.dotLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotLabel.Location = new System.Drawing.Point(15, 20);
            this.dotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dotLabel.Name = "dotLabel";
            this.dotLabel.Size = new System.Drawing.Size(49, 19);
            this.dotLabel.TabIndex = 252;
            this.dotLabel.Text = "DOT #";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(64, 209);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(177, 45);
            this.addressTextBox.TabIndex = 251;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(7, 212);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 15);
            this.addressLabel.TabIndex = 250;
            this.addressLabel.Text = "Address";
            // 
            // trucksTextBox
            // 
            this.trucksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trucksTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.trucksTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trucksTextBox.Location = new System.Drawing.Point(366, 134);
            this.trucksTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trucksTextBox.Name = "trucksTextBox";
            this.trucksTextBox.ReadOnly = true;
            this.trucksTextBox.Size = new System.Drawing.Size(59, 23);
            this.trucksTextBox.TabIndex = 249;
            this.trucksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driversTextBox
            // 
            this.driversTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.driversTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.driversTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversTextBox.Location = new System.Drawing.Point(279, 134);
            this.driversTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.driversTextBox.Name = "driversTextBox";
            this.driversTextBox.ReadOnly = true;
            this.driversTextBox.Size = new System.Drawing.Size(56, 23);
            this.driversTextBox.TabIndex = 248;
            this.driversTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trucksLabel
            // 
            this.trucksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trucksLabel.AutoSize = true;
            this.trucksLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trucksLabel.Location = new System.Drawing.Point(359, 118);
            this.trucksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trucksLabel.Name = "trucksLabel";
            this.trucksLabel.Size = new System.Drawing.Size(41, 15);
            this.trucksLabel.TabIndex = 247;
            this.trucksLabel.Text = "Trucks";
            // 
            // driversLabel
            // 
            this.driversLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.driversLabel.AutoSize = true;
            this.driversLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversLabel.Location = new System.Drawing.Point(276, 118);
            this.driversLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driversLabel.Name = "driversLabel";
            this.driversLabel.Size = new System.Drawing.Size(43, 15);
            this.driversLabel.TabIndex = 246;
            this.driversLabel.Text = "Drivers";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(64, 145);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(177, 23);
            this.phoneTextBox.TabIndex = 245;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(64, 174);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(177, 23);
            this.emailTextBox.TabIndex = 244;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(64, 83);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(177, 22);
            this.nameTextBox.TabIndex = 243;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(15, 148);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 15);
            this.phoneLabel.TabIndex = 242;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(20, 177);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 241;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(15, 87);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 240;
            this.nameLabel.Text = "Name";
            // 
            // notificationsSmallPanel
            // 
            this.notificationsSmallPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationsSmallPanel.Location = new System.Drawing.Point(279, 53);
            this.notificationsSmallPanel.Name = "notificationsSmallPanel";
            this.notificationsSmallPanel.Size = new System.Drawing.Size(146, 160);
            this.notificationsSmallPanel.TabIndex = 268;
            this.notificationsSmallPanel.Visible = false;
            // 
            // notinterestButton
            // 
            this.notinterestButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notinterestButton.LabelText = "Not Interested";
            this.notinterestButton.Location = new System.Drawing.Point(242, 10);
            this.notinterestButton.Name = "notinterestButton";
            this.notinterestButton.Size = new System.Drawing.Size(93, 42);
            this.notinterestButton.TabIndex = 268;
            // 
            // alarmButton
            // 
            this.alarmButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmButton.LabelText = "Set Alarm";
            this.alarmButton.Location = new System.Drawing.Point(179, 7);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(96, 42);
            this.alarmButton.TabIndex = 267;
            // 
            // transferButton
            // 
            this.transferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.LabelText = "Transfer";
            this.transferButton.Location = new System.Drawing.Point(152, 7);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(80, 57);
            this.transferButton.TabIndex = 269;
            // 
            // smsButton
            // 
            this.smsButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.smsButton.LabelText = "Text";
            this.smsButton.Location = new System.Drawing.Point(20, 10);
            this.smsButton.Name = "smsButton";
            this.smsButton.Size = new System.Drawing.Size(84, 42);
            this.smsButton.TabIndex = 266;
            // 
            // emailButton
            // 
            this.emailButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.emailButton.LabelText = "Email";
            this.emailButton.Location = new System.Drawing.Point(69, 7);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(91, 42);
            this.emailButton.TabIndex = 265;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.LabelText = "Delete Client";
            this.deleteButton.Location = new System.Drawing.Point(0, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 42);
            this.deleteButton.TabIndex = 0;
            // 
            // ClientInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftinfoPanel);
            this.Name = "ClientInfoPanel";
            this.Size = new System.Drawing.Size(454, 329);
            this.leftinfoPanel.ResumeLayout(false);
            this.leftinfoPanel.PerformLayout();
            this.allbuttonsPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftinfoPanel;
        private System.Windows.Forms.TextBox dbaTextBox;
        private System.Windows.Forms.Label dbaLabel;
        private System.Windows.Forms.TextBox MCTextBox;
        private System.Windows.Forms.Label MCLabel;
        private System.Windows.Forms.Label dotLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button updateinfoButton;
        private System.Windows.Forms.Panel allbuttonsPanel;
        private System.Windows.Forms.Label companytypeLabel;
        private System.Windows.Forms.TextBox dateaddedTextBox;
        private System.Windows.Forms.Label dateaddedLabel;
        private System.Windows.Forms.TextBox trucksTextBox;
        private System.Windows.Forms.TextBox driversTextBox;
        private System.Windows.Forms.Label trucksLabel;
        private System.Windows.Forms.Label driversLabel;
        private System.Windows.Forms.Button notificationsButton;
        private System.Windows.Forms.Panel adminPanel;
        private Controls.IconLabelButton deleteButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private Controls.IconLabelButton notinterestButton;
        private Controls.IconLabelButton alarmButton;
        private Controls.IconLabelButton transferButton;
        private Controls.IconLabelButton smsButton;
        private Controls.IconLabelButton emailButton;
        private Controls.NotificationsSmallPanel notificationsSmallPanel;
    }
}
