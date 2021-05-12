using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace csharpClient
{
    public partial class LogInPage : Form
    {
        //intialises variables for inputted ip and port
        static string ipAdd;
        static int port;

        //sets if the socket is connected by default
        bool socketConnect = false;
        //creates connection class
        Connection con = new Connection();

        public LogInPage()
        {
            InitializeComponent();
        }

        //what happens when log in button is pressed
        private void logInButton_Click(object sender, EventArgs e)
        {
            //checks is socket is connected
            if (socketConnect == true)
            {
                //if socket connected send the text in the username and password text box with an identifying letter at the start
                con.sendMessage("U" + usernameTextBox.Text);
                con.sendMessage("P" + passwordTextBox.Text);
                //receives the response of a 1 or 0 from server
                int response = Int32.Parse(con.getMessage());
                if (response == 0)
                {
                    //if response is 0, it means username and password are wrong and prints that your log in is incorrect
                    errorLabel.Text = "Username or Password is incorrect.";
                }
                else
                {
                    //if response is 1, it means username and password are correct and opens the main client
                    ClientPage form = new ClientPage();
                    this.Hide();
                    form.setUsername(usernameTextBox.Text + "#" + response);
                    form.Show();

                }
            }
            //socket not connected message
            else
            {
                errorLabel.Text = "Not connected to server";
            }
        }

        //if the exit button is clicked it closes the artefact
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
            {
                return;
            }
            Application.Exit();
        }

        //how it connects to the server
        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            //if statement to check if socket connected or not
            if (socketConnect == false)
            {
                //sets success by default
                bool success = true;
                //tries to connect to the server given your inputted ip and port
                try
                {
                    ipAdd = ipBox.Text;
                    port = Int32.Parse(portBox.Text);
                    con.createConnection(ipAdd, port);
                }
                //if you dont input an int in to the port text box it gives you an error message
                catch (FormatException)
                {
                    //sets success to false
                    success = false;
                    errorLabel.Text = "port is causing an error";
                }
                //if ip or port cannot connect it gives an error message
                catch (SocketException)
                {
                    //sets success to false
                    success = false;
                    errorLabel.Text = "IP or Port is incorrect";
                }
                //if success doesn't get set to false, it connects to the server
                if (success)
                {
                    //receives log in message from server
                    con.getMessage();
                    //sets socket connected bool to true
                    socketConnect = true;
                    //this disables the text box and button to enter IP and port if you have successfully connected to prevent errors
                    ipBox.Enabled = false;
                    portBox.Enabled = false;
                    ServerConnectButton.Enabled = false;
                }
            }
            //if it can't connect, do nothing
            else
            {

            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            if (socketConnect == true)
            {
                string tempUser;
                string tempPass;
                tempUser = con.noPunc(usernameTextBox.Text);
                tempPass = con.noPunc(passwordTextBox.Text);

                if (usernameTextBox.Text != tempUser)
                {
                    errorLabel.Text = "Username cannot contain symbols. Only Letters and Numbers.";
                }
                else if (passwordTextBox.Text != tempPass)
                {
                    errorLabel.Text = "Password cannot contain symbols. Only Letters and Numbers.";
                }
                else
                {
                    con.sendMessage("N" + usernameTextBox.Text + "-" + passwordTextBox.Text);
                }
                string response = con.getMessage();
                int responseInt = Int32.Parse(response);
                if (responseInt != -1)
                {
                    ClientPage form = new ClientPage();
                    this.Hide();
                    form.setUsername(usernameTextBox.Text + "#" + response);
                    form.Show();
                }
                else
                {
                    errorLabel.Text = "Username is taken.";
                }

            }
            else
            {
                errorLabel.Text = "Not connected to a server";
            }
        }
    }
}