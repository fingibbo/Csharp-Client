using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace csharpClient
{
    public partial class LogInPage : Form
    {
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("86.6.1.8"), 420); //

        public LogInPage()
        {
            InitializeComponent();


        }
        public void msgSender(string toSend)
        {
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }
        
        public void msgReceiver()
        {
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);
            BeginInvoke((Action)(() =>
            {
                receiveListBox.Items.Add(rcv);
                receiveListBox.SelectedIndex = receiveListBox.Items.Count - 1;
            }));
        }
        


        private void logInButton_Click(object sender, EventArgs e)
        {
            clientSocket.Connect(serverAddress);

            msgSender("U" + usernameTextBox.Text);
            msgSender("P" + passwordTextBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
            {
                return;
            }
            Application.Exit();
        }
    }
}
