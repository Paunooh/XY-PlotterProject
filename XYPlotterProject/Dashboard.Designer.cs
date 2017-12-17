namespace XYPlotterProject {
    partial class Dashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MQTTServerLabel = new System.Windows.Forms.Label();
            this.MQTTServerField = new System.Windows.Forms.TextBox();
            this.MQTTPortLabel = new System.Windows.Forms.Label();
            this.MQTTPortField = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DebugLog = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.clientIdField = new System.Windows.Forms.TextBox();
            this.ClientIdLabel = new System.Windows.Forms.Label();
            this.ClientIdGenerateButton = new System.Windows.Forms.Button();
            this.ClientIdUseButton = new System.Windows.Forms.Button();
            this.CurrentClientIdLabel = new System.Windows.Forms.TextBox();
            this.TopicDropdownMenu = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.AddNewTopicField = new System.Windows.Forms.TextBox();
            this.AddNewTopic = new System.Windows.Forms.Button();
            this.ReceivedMessagesField = new System.Windows.Forms.TextBox();
            this.SendCustomMessageButton = new System.Windows.Forms.Button();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.MessagesLabel = new System.Windows.Forms.Label();
            this.EventLogLabel = new System.Windows.Forms.Label();
            this.CustomMessageField = new System.Windows.Forms.TextBox();
            this.SendMessagesLabel = new System.Windows.Forms.Label();
            this.FlashProgramButton = new System.Windows.Forms.Button();
            this.StartProgramButton = new System.Windows.Forms.Button();
            this.StopPlotterButton = new System.Windows.Forms.Button();
            this.StartPlotterButton = new System.Windows.Forms.Button();
            this.CheckConnectionButton = new System.Windows.Forms.Button();
            this.UpdateProgramButton = new System.Windows.Forms.Button();
            this.ESPRestartButton = new System.Windows.Forms.Button();
            this.StopMusicButton = new System.Windows.Forms.Button();
            this.StartMusicButton = new System.Windows.Forms.Button();
            this.NextSongButton = new System.Windows.Forms.Button();
            this.PreviousSongButton = new System.Windows.Forms.Button();
            this.ApplyVolumeButton = new System.Windows.Forms.Button();
            this.VolumeField = new System.Windows.Forms.TextBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MQTTServerLabel
            // 
            this.MQTTServerLabel.AutoSize = true;
            this.MQTTServerLabel.Location = new System.Drawing.Point(212, 40);
            this.MQTTServerLabel.Name = "MQTTServerLabel";
            this.MQTTServerLabel.Size = new System.Drawing.Size(72, 13);
            this.MQTTServerLabel.TabIndex = 3;
            this.MQTTServerLabel.Text = "MQTT Server";
            // 
            // MQTTServerField
            // 
            this.MQTTServerField.Location = new System.Drawing.Point(12, 37);
            this.MQTTServerField.Name = "MQTTServerField";
            this.MQTTServerField.Size = new System.Drawing.Size(194, 20);
            this.MQTTServerField.TabIndex = 2;
            this.MQTTServerField.Text = "iot.eclipse.org";
            // 
            // MQTTPortLabel
            // 
            this.MQTTPortLabel.AutoSize = true;
            this.MQTTPortLabel.Location = new System.Drawing.Point(212, 66);
            this.MQTTPortLabel.Name = "MQTTPortLabel";
            this.MQTTPortLabel.Size = new System.Drawing.Size(60, 13);
            this.MQTTPortLabel.TabIndex = 5;
            this.MQTTPortLabel.Text = "MQTT Port";
            // 
            // MQTTPortField
            // 
            this.MQTTPortField.Location = new System.Drawing.Point(12, 63);
            this.MQTTPortField.Name = "MQTTPortField";
            this.MQTTPortField.Size = new System.Drawing.Size(194, 20);
            this.MQTTPortField.TabIndex = 4;
            this.MQTTPortField.Text = "1883";
            this.MQTTPortField.TextChanged += new System.EventHandler(this.MQTTPortField_TextChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 141);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(95, 20);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DebugLog
            // 
            this.DebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugLog.Location = new System.Drawing.Point(12, 331);
            this.DebugLog.Multiline = true;
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.ReadOnly = true;
            this.DebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugLog.Size = new System.Drawing.Size(600, 98);
            this.DebugLog.TabIndex = 7;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(113, 141);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(93, 20);
            this.DisconnectButton.TabIndex = 8;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // clientIdField
            // 
            this.clientIdField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientIdField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.clientIdField.Location = new System.Drawing.Point(326, 37);
            this.clientIdField.Name = "clientIdField";
            this.clientIdField.Size = new System.Drawing.Size(212, 20);
            this.clientIdField.TabIndex = 9;
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Location = new System.Drawing.Point(323, 21);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.ClientIdLabel.TabIndex = 10;
            this.ClientIdLabel.Text = "Client ID";
            // 
            // ClientIdGenerateButton
            // 
            this.ClientIdGenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientIdGenerateButton.Location = new System.Drawing.Point(544, 37);
            this.ClientIdGenerateButton.Name = "ClientIdGenerateButton";
            this.ClientIdGenerateButton.Size = new System.Drawing.Size(68, 20);
            this.ClientIdGenerateButton.TabIndex = 11;
            this.ClientIdGenerateButton.Text = "Generate";
            this.ClientIdGenerateButton.UseVisualStyleBackColor = true;
            this.ClientIdGenerateButton.Click += new System.EventHandler(this.ClientIdGenerateButton_Click);
            // 
            // ClientIdUseButton
            // 
            this.ClientIdUseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientIdUseButton.Location = new System.Drawing.Point(544, 63);
            this.ClientIdUseButton.Name = "ClientIdUseButton";
            this.ClientIdUseButton.Size = new System.Drawing.Size(68, 20);
            this.ClientIdUseButton.TabIndex = 12;
            this.ClientIdUseButton.Text = "Use";
            this.ClientIdUseButton.UseVisualStyleBackColor = true;
            this.ClientIdUseButton.Click += new System.EventHandler(this.ClientIdUseButton_Click);
            // 
            // CurrentClientIdLabel
            // 
            this.CurrentClientIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentClientIdLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CurrentClientIdLabel.Location = new System.Drawing.Point(326, 63);
            this.CurrentClientIdLabel.Name = "CurrentClientIdLabel";
            this.CurrentClientIdLabel.ReadOnly = true;
            this.CurrentClientIdLabel.Size = new System.Drawing.Size(212, 20);
            this.CurrentClientIdLabel.TabIndex = 14;
            this.CurrentClientIdLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopicDropdownMenu
            // 
            this.TopicDropdownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicDropdownMenu.FormattingEnabled = true;
            this.TopicDropdownMenu.Location = new System.Drawing.Point(326, 106);
            this.TopicDropdownMenu.Name = "TopicDropdownMenu";
            this.TopicDropdownMenu.Size = new System.Drawing.Size(212, 21);
            this.TopicDropdownMenu.TabIndex = 15;
            this.TopicDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.TopicDropdownMenu_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Location = new System.Drawing.Point(544, 106);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(68, 21);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNewTopicField
            // 
            this.AddNewTopicField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewTopicField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AddNewTopicField.Location = new System.Drawing.Point(326, 133);
            this.AddNewTopicField.Name = "AddNewTopicField";
            this.AddNewTopicField.Size = new System.Drawing.Size(212, 20);
            this.AddNewTopicField.TabIndex = 17;
            this.AddNewTopicField.TextChanged += new System.EventHandler(this.AddNewTopicField_TextChanged);
            // 
            // AddNewTopic
            // 
            this.AddNewTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewTopic.Enabled = false;
            this.AddNewTopic.Location = new System.Drawing.Point(544, 133);
            this.AddNewTopic.Name = "AddNewTopic";
            this.AddNewTopic.Size = new System.Drawing.Size(68, 20);
            this.AddNewTopic.TabIndex = 18;
            this.AddNewTopic.Text = "Add Topic";
            this.AddNewTopic.UseVisualStyleBackColor = true;
            this.AddNewTopic.Click += new System.EventHandler(this.AddNewTopic_Click);
            // 
            // ReceivedMessagesField
            // 
            this.ReceivedMessagesField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedMessagesField.Location = new System.Drawing.Point(326, 200);
            this.ReceivedMessagesField.Multiline = true;
            this.ReceivedMessagesField.Name = "ReceivedMessagesField";
            this.ReceivedMessagesField.ReadOnly = true;
            this.ReceivedMessagesField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedMessagesField.Size = new System.Drawing.Size(286, 125);
            this.ReceivedMessagesField.TabIndex = 19;
            // 
            // SendCustomMessageButton
            // 
            this.SendCustomMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendCustomMessageButton.Location = new System.Drawing.Point(544, 173);
            this.SendCustomMessageButton.Name = "SendCustomMessageButton";
            this.SendCustomMessageButton.Size = new System.Drawing.Size(68, 20);
            this.SendCustomMessageButton.TabIndex = 21;
            this.SendCustomMessageButton.Text = "Send";
            this.SendCustomMessageButton.UseVisualStyleBackColor = true;
            this.SendCustomMessageButton.Click += new System.EventHandler(this.SendCustomMessageButton_Click);
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(9, 21);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerLabel.TabIndex = 22;
            this.ServerLabel.Text = "Server";
            // 
            // TopicLabel
            // 
            this.TopicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(323, 90);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(39, 13);
            this.TopicLabel.TabIndex = 23;
            this.TopicLabel.Text = "Topics";
            // 
            // MessagesLabel
            // 
            this.MessagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesLabel.AutoSize = true;
            this.MessagesLabel.Location = new System.Drawing.Point(323, 158);
            this.MessagesLabel.Name = "MessagesLabel";
            this.MessagesLabel.Size = new System.Drawing.Size(55, 13);
            this.MessagesLabel.TabIndex = 24;
            this.MessagesLabel.Text = "Messages";
            // 
            // EventLogLabel
            // 
            this.EventLogLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventLogLabel.AutoSize = true;
            this.EventLogLabel.Location = new System.Drawing.Point(9, 315);
            this.EventLogLabel.Name = "EventLogLabel";
            this.EventLogLabel.Size = new System.Drawing.Size(56, 13);
            this.EventLogLabel.TabIndex = 25;
            this.EventLogLabel.Text = "Event Log";
            // 
            // CustomMessageField
            // 
            this.CustomMessageField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomMessageField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CustomMessageField.Location = new System.Drawing.Point(326, 174);
            this.CustomMessageField.Name = "CustomMessageField";
            this.CustomMessageField.Size = new System.Drawing.Size(212, 20);
            this.CustomMessageField.TabIndex = 26;
            // 
            // SendMessagesLabel
            // 
            this.SendMessagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendMessagesLabel.AutoSize = true;
            this.SendMessagesLabel.Location = new System.Drawing.Point(9, 184);
            this.SendMessagesLabel.Name = "SendMessagesLabel";
            this.SendMessagesLabel.Size = new System.Drawing.Size(83, 13);
            this.SendMessagesLabel.TabIndex = 27;
            this.SendMessagesLabel.Text = "Send Messages";
            // 
            // FlashProgramButton
            // 
            this.FlashProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlashProgramButton.Location = new System.Drawing.Point(12, 200);
            this.FlashProgramButton.Name = "FlashProgramButton";
            this.FlashProgramButton.Size = new System.Drawing.Size(95, 20);
            this.FlashProgramButton.TabIndex = 28;
            this.FlashProgramButton.Text = "Flash Program";
            this.FlashProgramButton.UseVisualStyleBackColor = true;
            this.FlashProgramButton.Click += new System.EventHandler(this.FlashProgramButton_Click);
            // 
            // StartProgramButton
            // 
            this.StartProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartProgramButton.Location = new System.Drawing.Point(113, 199);
            this.StartProgramButton.Name = "StartProgramButton";
            this.StartProgramButton.Size = new System.Drawing.Size(93, 21);
            this.StartProgramButton.TabIndex = 29;
            this.StartProgramButton.Text = "Start Program";
            this.StartProgramButton.UseVisualStyleBackColor = true;
            this.StartProgramButton.Click += new System.EventHandler(this.StartProgramButton_Click);
            // 
            // StopPlotterButton
            // 
            this.StopPlotterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopPlotterButton.Location = new System.Drawing.Point(113, 226);
            this.StopPlotterButton.Name = "StopPlotterButton";
            this.StopPlotterButton.Size = new System.Drawing.Size(93, 21);
            this.StopPlotterButton.TabIndex = 31;
            this.StopPlotterButton.Text = "Stop Plotter";
            this.StopPlotterButton.UseVisualStyleBackColor = true;
            this.StopPlotterButton.Click += new System.EventHandler(this.StopPlotterButton_Click);
            // 
            // StartPlotterButton
            // 
            this.StartPlotterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartPlotterButton.Location = new System.Drawing.Point(12, 227);
            this.StartPlotterButton.Name = "StartPlotterButton";
            this.StartPlotterButton.Size = new System.Drawing.Size(95, 20);
            this.StartPlotterButton.TabIndex = 30;
            this.StartPlotterButton.Text = "Start Plotter";
            this.StartPlotterButton.UseVisualStyleBackColor = true;
            this.StartPlotterButton.Click += new System.EventHandler(this.StartPlotterButton_Click);
            // 
            // CheckConnectionButton
            // 
            this.CheckConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckConnectionButton.Location = new System.Drawing.Point(212, 226);
            this.CheckConnectionButton.Name = "CheckConnectionButton";
            this.CheckConnectionButton.Size = new System.Drawing.Size(93, 21);
            this.CheckConnectionButton.TabIndex = 33;
            this.CheckConnectionButton.Text = "Try Connection";
            this.CheckConnectionButton.UseVisualStyleBackColor = true;
            this.CheckConnectionButton.Click += new System.EventHandler(this.CheckConnectionButton_Click);
            // 
            // UpdateProgramButton
            // 
            this.UpdateProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateProgramButton.Location = new System.Drawing.Point(212, 199);
            this.UpdateProgramButton.Name = "UpdateProgramButton";
            this.UpdateProgramButton.Size = new System.Drawing.Size(93, 21);
            this.UpdateProgramButton.TabIndex = 32;
            this.UpdateProgramButton.Text = "Update Program";
            this.UpdateProgramButton.UseVisualStyleBackColor = true;
            this.UpdateProgramButton.Click += new System.EventHandler(this.UpdateProgramButton_Click);
            // 
            // ESPRestartButton
            // 
            this.ESPRestartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ESPRestartButton.Location = new System.Drawing.Point(212, 253);
            this.ESPRestartButton.Name = "ESPRestartButton";
            this.ESPRestartButton.Size = new System.Drawing.Size(93, 21);
            this.ESPRestartButton.TabIndex = 36;
            this.ESPRestartButton.Text = "ESP Restart";
            this.ESPRestartButton.UseVisualStyleBackColor = true;
            this.ESPRestartButton.Click += new System.EventHandler(this.ESPRestartButton_Click);
            // 
            // StopMusicButton
            // 
            this.StopMusicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopMusicButton.Location = new System.Drawing.Point(113, 253);
            this.StopMusicButton.Name = "StopMusicButton";
            this.StopMusicButton.Size = new System.Drawing.Size(93, 21);
            this.StopMusicButton.TabIndex = 35;
            this.StopMusicButton.Text = "Stop Music";
            this.StopMusicButton.UseVisualStyleBackColor = true;
            this.StopMusicButton.Click += new System.EventHandler(this.StopMusicButton_Click);
            // 
            // StartMusicButton
            // 
            this.StartMusicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartMusicButton.Location = new System.Drawing.Point(12, 253);
            this.StartMusicButton.Name = "StartMusicButton";
            this.StartMusicButton.Size = new System.Drawing.Size(95, 20);
            this.StartMusicButton.TabIndex = 34;
            this.StartMusicButton.Text = "Start Music";
            this.StartMusicButton.UseVisualStyleBackColor = true;
            this.StartMusicButton.Click += new System.EventHandler(this.StartMusicButton_Click);
            // 
            // NextSongButton
            // 
            this.NextSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextSongButton.Location = new System.Drawing.Point(12, 292);
            this.NextSongButton.Name = "NextSongButton";
            this.NextSongButton.Size = new System.Drawing.Size(95, 20);
            this.NextSongButton.TabIndex = 37;
            this.NextSongButton.Text = "Next Song";
            this.NextSongButton.UseVisualStyleBackColor = true;
            this.NextSongButton.Click += new System.EventHandler(this.NextSongButton_Click);
            // 
            // PreviousSongButton
            // 
            this.PreviousSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousSongButton.Location = new System.Drawing.Point(113, 292);
            this.PreviousSongButton.Name = "PreviousSongButton";
            this.PreviousSongButton.Size = new System.Drawing.Size(93, 21);
            this.PreviousSongButton.TabIndex = 38;
            this.PreviousSongButton.Text = "Previous Song";
            this.PreviousSongButton.UseVisualStyleBackColor = true;
            this.PreviousSongButton.Click += new System.EventHandler(this.PreviousSongButton_Click);
            // 
            // ApplyVolumeButton
            // 
            this.ApplyVolumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyVolumeButton.Location = new System.Drawing.Point(257, 292);
            this.ApplyVolumeButton.Name = "ApplyVolumeButton";
            this.ApplyVolumeButton.Size = new System.Drawing.Size(48, 21);
            this.ApplyVolumeButton.TabIndex = 39;
            this.ApplyVolumeButton.Text = "Apply Volume";
            this.ApplyVolumeButton.UseVisualStyleBackColor = true;
            this.ApplyVolumeButton.Click += new System.EventHandler(this.ApplyVolumeButton_Click);
            // 
            // VolumeField
            // 
            this.VolumeField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VolumeField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.VolumeField.Location = new System.Drawing.Point(212, 293);
            this.VolumeField.Name = "VolumeField";
            this.VolumeField.Size = new System.Drawing.Size(42, 20);
            this.VolumeField.TabIndex = 40;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(212, 277);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 41;
            this.VolumeLabel.Text = "Volume";
            // 
            // UsernameField
            // 
            this.UsernameField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.UsernameField.Location = new System.Drawing.Point(12, 89);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(194, 20);
            this.UsernameField.TabIndex = 42;
            this.UsernameField.TextChanged += new System.EventHandler(this.UsernameField_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PasswordField.Location = new System.Drawing.Point(12, 115);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(194, 20);
            this.PasswordField.TabIndex = 43;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(212, 92);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 44;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(212, 118);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 45;
            this.PasswordLabel.Text = "Password";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumeField);
            this.Controls.Add(this.ApplyVolumeButton);
            this.Controls.Add(this.PreviousSongButton);
            this.Controls.Add(this.NextSongButton);
            this.Controls.Add(this.ESPRestartButton);
            this.Controls.Add(this.StopMusicButton);
            this.Controls.Add(this.StartMusicButton);
            this.Controls.Add(this.CheckConnectionButton);
            this.Controls.Add(this.UpdateProgramButton);
            this.Controls.Add(this.StopPlotterButton);
            this.Controls.Add(this.StartPlotterButton);
            this.Controls.Add(this.StartProgramButton);
            this.Controls.Add(this.FlashProgramButton);
            this.Controls.Add(this.SendMessagesLabel);
            this.Controls.Add(this.CustomMessageField);
            this.Controls.Add(this.EventLogLabel);
            this.Controls.Add(this.MessagesLabel);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.SendCustomMessageButton);
            this.Controls.Add(this.ReceivedMessagesField);
            this.Controls.Add(this.AddNewTopic);
            this.Controls.Add(this.AddNewTopicField);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.TopicDropdownMenu);
            this.Controls.Add(this.CurrentClientIdLabel);
            this.Controls.Add(this.ClientIdUseButton);
            this.Controls.Add(this.ClientIdGenerateButton);
            this.Controls.Add(this.ClientIdLabel);
            this.Controls.Add(this.clientIdField);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.DebugLog);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MQTTPortLabel);
            this.Controls.Add(this.MQTTPortField);
            this.Controls.Add(this.MQTTServerLabel);
            this.Controls.Add(this.MQTTServerField);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Dashboard";
            this.Text = "XY-Plotter Program";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label MQTTServerLabel;
        internal System.Windows.Forms.TextBox MQTTServerField;
        internal System.Windows.Forms.Label MQTTPortLabel;
        internal System.Windows.Forms.TextBox MQTTPortField;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox DebugLog;
        private System.Windows.Forms.Button DisconnectButton;
        internal System.Windows.Forms.TextBox clientIdField;
        internal System.Windows.Forms.Label ClientIdLabel;
        private System.Windows.Forms.Button ClientIdGenerateButton;
        private System.Windows.Forms.Button ClientIdUseButton;
        private System.Windows.Forms.TextBox CurrentClientIdLabel;
        private System.Windows.Forms.ComboBox TopicDropdownMenu;
        private System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.TextBox AddNewTopicField;
        private System.Windows.Forms.Button AddNewTopic;
        private System.Windows.Forms.TextBox ReceivedMessagesField;
        private System.Windows.Forms.Button SendCustomMessageButton;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Label MessagesLabel;
        private System.Windows.Forms.Label EventLogLabel;
        internal System.Windows.Forms.TextBox CustomMessageField;
        private System.Windows.Forms.Label SendMessagesLabel;
        private System.Windows.Forms.Button FlashProgramButton;
        private System.Windows.Forms.Button StartProgramButton;
        private System.Windows.Forms.Button StopPlotterButton;
        private System.Windows.Forms.Button StartPlotterButton;
        private System.Windows.Forms.Button CheckConnectionButton;
        private System.Windows.Forms.Button UpdateProgramButton;
        private System.Windows.Forms.Button ESPRestartButton;
        private System.Windows.Forms.Button StopMusicButton;
        private System.Windows.Forms.Button StartMusicButton;
        private System.Windows.Forms.Button NextSongButton;
        private System.Windows.Forms.Button PreviousSongButton;
        private System.Windows.Forms.Button ApplyVolumeButton;
        internal System.Windows.Forms.TextBox VolumeField;
        private System.Windows.Forms.Label VolumeLabel;
        internal System.Windows.Forms.TextBox UsernameField;
        internal System.Windows.Forms.TextBox PasswordField;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.Label PasswordLabel;
    }
}

