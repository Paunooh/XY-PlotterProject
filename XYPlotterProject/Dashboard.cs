/*
 * Eetu Piispa
 * 7.12.2017    - first version to work?
 * for IoT Project
 * 
 * a whole lot of ifs and elses, better not crash?
 */

using System;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Security.Cryptography.X509Certificates;

namespace XYPlotterProject {
    public partial class Dashboard : Form {

        /*
         * Backend IP:      34.252.123.210
         * Backend name:    backend.abelonditi.com
         * MQTT port:       1883 (insecure)     8883 (secure SSL/TLS)
         * MongoDB port:    27017
         * Topics:          <TeamID>/<collection>/<device>
         */

        private string backendCert = Environment.CurrentDirectory + @"\backendCert.cer";
        private string MQTTServerAddress = "";
        private string clientId = "";
        private string sentMessage = "";
        private string username = "";
        private string password = "";
        private int MQTTPortNumber = 0;
        private int selectedTopic = 0;
        private MqttClient client = null;
        private TopicList topicList = new TopicList();

        private string clientInfo = "\r\nTarget info:\r\nUser = team05\r\nPass = menam\r\n" + 
                            "inTopic = ESP32_LPC1549_HOST_IN\r\noutTopic = ESP32_LPC1549_HOST_OUT\r\n" +
                            "cmdTopic = ESP32_LPC1549_CMD\r\nBackend IP = 34.252.123.210\r\n Backend name = backend.abelonditi.com\r\n" +
                            "MQTT port = 1883 (insecure)     8883 (secure SSL/TLS)\r\nPublish topics like = <TeamID>/<collection>/<device>\r\n";


        private bool connected = false;

        private void Dashboard_Load(object sender, EventArgs e) {
            MQTTPortNumber = MQTTPortNumber = Int32.Parse(MQTTPortField.Text);
        }

        private void Dashboard_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            if (client.IsConnected) {
                client.Disconnect();
            }
        }

        public Dashboard() {
            InitializeComponent();
        }

        delegate void SetTextCallback(string text);


        //
        //  Writes to Log textbox at the bottom of program
        //
        private void Log(string message) {
            DebugLog.AppendText(message + "\r\n");
        }


        //
        //  Writes message to the messages field
        //
        public void NewMessage(string message) {
            if (this.ReceivedMessagesField.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(NewMessage);
                this.Invoke(d, new object[] { message });
            } else {
                ReceivedMessagesField.AppendText(message + "\r\n");
                topicList.Get(selectedTopic).Message(message);
                if (message == "Sent item: info") {
                    Log(clientInfo);
                }
            }
        }


        //
        //  Sends a message to selected topic
        //
        private void SendMessage(string message) {
            if (client != null) {
                if (client.IsConnected) {
                    if (topicList.Length() > 0) {
                        client.Publish(topicList.Get(selectedTopic).Name, Encoding.UTF8.GetBytes(message));
                        Log("Message sent to: " + topicList.Get(selectedTopic).Name);
                    } else {
                        Log("Unable to send message!");
                    }
                } else {
                    Log("Not connected.");
                }
            } else {
                Log("No client found.");
            }
        }


        //
        //  Change MQTT port (NOT USED IN ANYTHING, EXISTS FOR SHITS AND GIGGLES)
        //
        private void MQTTPortField_TextChanged(object sender, EventArgs e) {
            try {
                MQTTPortNumber = Int32.Parse(MQTTPortField.Text);
            } catch {
                Log("Given port is not a valid number.");
            }
        }


        //
        //  Connects client
        //
        private void ConnectButton_Click(object sender, EventArgs e) {
            if (!connected) {
                Log(Environment.CurrentDirectory);
                MQTTServerAddress = MQTTServerField.Text;
                if (MQTTPortNumber != 1883) {
                    client = new MqttClient(MQTTServerAddress, MQTTPortNumber, true, new X509Certificate(backendCert), null, MqttSslProtocols.TLSv1_0);
                } else {
                    client = new MqttClient(MQTTServerAddress);
                }
                try {
                    if (clientId != "") {
                        client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                        if (username.Length > 0 && password.Length > 0) {
                            client.Connect(clientId, username, password);
                        } else {
                            client.Connect(clientId);
                        }
                        if (client.IsConnected) {
                            DisconnectButton.Enabled = true;
                            ConnectButton.Enabled = false;
                            connected = true;
                            Log("Connected to address: " + MQTTServerAddress);
                        } else {
                            Log("Unable to connect to address: " + MQTTServerAddress);
                        }
                    } else {
                        Log("No client ID.");
                    }
                } catch {
                    Log("Unable to connect to address: " + MQTTServerAddress);
                }
            }
        }


        //
        //  Disconnect client
        //
        private void DisconnectButton_Click(object sender, EventArgs e) {
            if (connected) {
                try {
                    client.Disconnect();
                    topicList = new TopicList();
                    TopicDropdownMenu.Text = "";
                    ReceivedMessagesField.Text = "";
                    TopicDropdownMenu.Items.Clear();
                    client = null;
                    connected = false;
                    DisconnectButton.Enabled = false;
                    ConnectButton.Enabled = true;
                    Log("You have disconnected.");
                }
                catch {
                    Log("Unable to disconnect.");
                }
            }
        }


        //
        //  Generate a random client ID
        //
        private void ClientIdGenerateButton_Click(object sender, EventArgs e) {
            clientIdField.Text = Guid.NewGuid().ToString();
            Log("New client ID Randomized.");
        }


        //
        //  Set client ID button
        //
        private void ClientIdUseButton_Click(object sender, EventArgs e)
        {
            if (clientIdField.Text != "") {
                clientId = clientIdField.Text;
                CurrentClientIdLabel.Text = clientId;
                Log("Changed client ID to: " + clientId);
            } else {
                clientIdField.Text = clientId;
                Log("Empty client ID");
            }
        }


        //
        //  Topic selection dropdown menu
        //
        private void TopicDropdownMenu_SelectedIndexChanged(object sender, EventArgs e) {
            if (topicList.Exists(TopicDropdownMenu.Text)) {
                selectedTopic = topicList.Get(TopicDropdownMenu.Text);
                ReceivedMessagesField.Text = topicList.Get(selectedTopic).Messages;
            }
        }


        //
        //  Add new topic button
        //
        private void AddNewTopic_Click(object sender, EventArgs e) {
            if (!topicList.Exists(AddNewTopicField.Text)) {
                if (client != null) {
                    if (client.IsConnected) {
                        topicList.Add(new Topic(AddNewTopicField.Text));
                        TopicDropdownMenu.Items.Add(AddNewTopicField.Text);
                        selectedTopic = topicList.Length();
                        TopicDropdownMenu.Text = AddNewTopicField.Text;
                        client.Subscribe(new string[] { AddNewTopicField.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                        Log("Added new topic: " + AddNewTopicField.Text);
                    } else {
                        Log("Client is not connected!");
                    }
                } else {
                    Log("Client is not connected!");
                }
            } else {
                Log("Topic already exists!");
            }
        }


        //
        //  New topic text field
        //
        private void AddNewTopicField_TextChanged(object sender, EventArgs e) {
            if (AddNewTopicField.Text.Length > 0) {
                AddNewTopic.Enabled = true;
            } else {
                AddNewTopic.Enabled = false;
            }
        }


        //
        //  Delete topic
        //
        private void Delete_Click(object sender, EventArgs e) {
            if (topicList.Length() > 0) {
                if (topicList.Exists(topicList.Get(selectedTopic).Name)) {
                    Log("Item removed: " + topicList.Get(selectedTopic).Name);
                    string[] s = new string[] { topicList.Get(selectedTopic).Name };
                    client.Unsubscribe(s);
                    topicList.Remove(selectedTopic);
                    TopicDropdownMenu.Items.RemoveAt(selectedTopic);
                    selectedTopic = 0;
                    if (topicList.Length() > 0) {
                        TopicDropdownMenu.Text = topicList.Get(selectedTopic).Name;
                    } else {
                        TopicDropdownMenu.Text = "";
                        ReceivedMessagesField.Text = "";
                    }
                } else {
                    Log("Item not found.");
                }
            } else {
                Log("No topic selected.");
            }
        }


        //
        //  MQTT receive message
        //
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {
            string message = Encoding.UTF8.GetString(e.Message);
            if (message == sentMessage) {
                NewMessage("Sent item: " + message);
                sentMessage = "";
            } else {
                NewMessage("Received item: " + message);
            }
        }


        //
        //  Send custom message
        //
        private void SendCustomMessageButton_Click(object sender, EventArgs e) {
            if (CustomMessageField.Text.Length > 0) {
                string str = Convert.ToString(CustomMessageField.Text);
                sentMessage = str;
                SendMessage(CustomMessageField.Text);
            } else {
                Log("Custom message field is empty.");
            }
        }


        //
        //  Preset commands
        //
        private void FlashProgramButton_Click(object sender, EventArgs e) {
            SendMessage("flash program");
        }

        private void StartProgramButton_Click(object sender, EventArgs e) {
            SendMessage("start program");
        }

        private void StartPlotterButton_Click(object sender, EventArgs e) {
            SendMessage("start plotter");
        }

        private void StopPlotterButton_Click(object sender, EventArgs e) {
            SendMessage("stop plotter");
        }

        private void UpdateProgramButton_Click(object sender, EventArgs e) {
            SendMessage("update program");
        }

        private void CheckConnectionButton_Click(object sender, EventArgs e) {
            SendMessage("?");
        }

        private void StartMusicButton_Click(object sender, EventArgs e) {
            SendMessage("start music");
        }

        private void StopMusicButton_Click(object sender, EventArgs e) {
            SendMessage("stop music");
        }

        private void ESPRestartButton_Click(object sender, EventArgs e) {
            SendMessage("esp restart");
        }

        private void NextSongButton_Click(object sender, EventArgs e) {
            SendMessage("next song");
        }

        private void PreviousSongButton_Click(object sender, EventArgs e) {
            SendMessage("prev song");
        }

        private void ApplyVolumeButton_Click(object sender, EventArgs e) {
            string msg = VolumeField.Text;
            int n;
            if (int.TryParse(msg, out n)) {
                if (n >= 0 && n <= 100) {
                    SendMessage("volume " + msg);
                }
                else {
                    Log("Value must be between 0 and 100.");
                }
            } 
            else {
                Log("Value must be a number.");
            }
        }


        //
        //  Set Username
        //
        private void UsernameField_TextChanged(object sender, EventArgs e) {
            try {
                username = UsernameField.Text;
            } catch {
                Log("Unable to use username.");
            }
        }


        //
        //  Set Password
        //
        private void PasswordField_TextChanged(object sender, EventArgs e) {
            try {
                password = PasswordField.Text;
            } catch {
                Log("Unable to use password.");
            }
        }
    }
}
