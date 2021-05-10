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
        bool socketConnect = false;
        Connection con = new Connection();

        public LogInPage()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(socketConnect == true)
            {
                con.sendMessage("U" + usernameTextBox.Text);
                con.sendMessage("P" + passwordTextBox.Text);
                con.getMessage();
            }
            else
            {
                errorLabel.Text = "Not connected to server";
            }
            /*ClientPage objClientPAge = new ClientPage();
            this.Hide();
            ClientPage.Show(); */
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
                    ipAdd = ipBox.Text;
                    port = Int32.Parse(portBox.Text);
                    con.createConnection(ipAdd, port);
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
                    con.getMessage();
                    socketConnect = true;
                }
            }
            else
            {

            }

        }
    }
}
