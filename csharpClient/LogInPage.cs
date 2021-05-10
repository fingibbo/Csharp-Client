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
using System.Timers;

namespace csharpClient
{
    public partial class LogInPage : Form
    {
        static string ipAdd;
        static int port;
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint serverAddress; //"86.6.1.8";
        bool socketConnect = false;
        private static System.Timers.Timer pingTimer;

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
            if (socketConnect == false)
            {

            }
            else
            {
                byte[] rcvLenBytes = new byte[4];
                clientSocket.Receive(rcvLenBytes);
                int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
                byte[] rcvBytes = new byte[rcvLen];
                clientSocket.Receive(rcvBytes);
                String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);
                readerBox.Items.Add(rcv);
            }
        }
        private void SetupPing()
        {
            double interval = 100.0;
            pingTimer = new System.Timers.Timer(interval);
            pingTimer.Elapsed += new ElapsedEventHandler(doPing);

        }
        private void doPing(object source, ElapsedEventArgs e)
        {
            msgSender("");
        }



        private void logInButton_Click(object sender, EventArgs e)
        {
            if(socketConnect == true)
            {
                msgSender("U" + usernameTextBox.Text);
                msgSender("P" + passwordTextBox.Text);
                msgReceiver();
            }
            else
            {
                errorLabel.Text = "Not connected to server";
            }



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
            {
                return;
            }
            Application.Exit();
        }

        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            if (socketConnect == false)
            {
                bool success = true;
                try
                {
                    serverAddress = new IPEndPoint(IPAddress.Parse(ipAdd), port)
                    port = Int32.Parse(portBox.Text);
                    clientSocket.Connect(serverAddress);
                }
                catch (FormatException)
                {
                    success = false;
                    errorLabel.Text = "port is causing an error";
                }
                catch (SocketException)
                {
                    success = false;
                    errorLabel.Text = "IP or Port is incorrect";
                }
                if (success)
                {
                    msgReceiver();
                    socketConnect = true;
                }
            }
            else
            {

            }

        }
    }
}
