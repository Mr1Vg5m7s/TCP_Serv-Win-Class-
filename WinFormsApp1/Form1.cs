using Client;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        UserConnection Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Client != null)
                {
                    Client.Disconnect();
                }
            }
            catch (Exception)
            {

            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;
                Client = new UserConnection(
                    txtClientName.Text,
                    System.Net.IPAddress.Parse(txtIPAdrress.Text),
                    Convert.ToInt32(txtPort.Text));
                Client.ConnectedEstablished += Client_ConnectedEstablished;
                Client.IncomingMessage += Client_IncomingMessage;
                await Client.ConnectAsync();
                await Client.ReadMessageAsync();
            }
            catch (Exception ex)
            {
                Client = null;
                btnConnect.Enabled = false;
                richTextBox1.Text += $"ERROR: {ex.Message}";
            }
        }

        private void Client_IncomingMessage(string message)
        {
            Action action = () =>
            {
                richTextBox1.Text += $"\n{message}";
            };
            Invoke(action);
        }

        private void Client_ConnectedEstablished(bool isConnected)
        {
            Action action = () =>
            {
                if (isConnected)
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    btnSend.Enabled = true;
                    txtMessage.Enabled = true;
                    txtIPAdrress.Enabled = false;
                    txtPort.Enabled = false;
                    txtClientName.Enabled = false;
                    listBox1.Enabled = true;
                }
                else
                {
                    btnConnect.Enabled = true;
                    btnDisconnect.Enabled = false;
                    btnSend.Enabled = false;
                    txtMessage.Enabled = false;
                    txtIPAdrress.Enabled = true;
                    txtPort.Enabled = true;
                    txtClientName.Enabled = true;
                    listBox1.Enabled = false;
                }
            };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }
    }
}