using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace csharpClient
{
    public partial class ClientPage : Form
    {
        Connection con = new Connection();
        private static System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private bool newGchat = false;
        private string[][] groupData;
        private string currentGroup;
        List<RadioButton> groupButtons = new List<RadioButton>(0);

        public ClientPage()
        {
            InitializeComponent();
            updateTimer.Tick += new EventHandler(updateCheck);
            updateTimer.Start();
            


        }

        private void updateCheck(object source, EventArgs e)
        {
            groupSorter();
            msgSorter();
        }

        private void groupSorter()
        {
            con.sendMessage("UGL");
            string response = con.getMessage();

                string[] data = ((string)response.Clone()).Split(new char[] { ':', ',' });
                string[][] postData = new string[data.Length / 2][];
                for (int i = 0; i < data.Length; i += 2)
                {
                    postData[i / 2] = new string[2];
                    postData[i / 2][0] = data[i];
                    postData[i / 2][1] = data[i + 1];
                }

                groupButtons.Clear();
                for (int i = 0; i < postData.Length; i++)
                {
                    groupButtons.Add(new RadioButton());
                    groupButtons[i].Width = 300;
                    groupButtons[i].Text = (i + 1) + ". " + postData[i][1];
                    groupButtons[i].Location = new Point(10, 10 + i * 20);
                    radioGroupBox.Controls.Add(groupButtons[i]);
                    groupButtons[i].CheckedChanged += new EventHandler(groupButtons_CheckedChanged);
                }
                groupData = postData;
            

            
        }
        private void msgSorter()
        {

            con.sendMessage("UFGD");
            string[] messagePrint = con.getMessage().Split(new char[] { '|' });

            if (newGchat == true)
            {
                messageBox.Items.Clear();
                for (int i = 0; i < messagePrint.Length; i += 4)
                {
                    if (messagePrint.Length >= 4)
                    {
                        messageBox.Items.Add("-------------");
                        messageBox.Items.Add(messagePrint[1 + i] + " || " + messagePrint[i]);
                        messageBox.Items.Add(messagePrint[2 + i]);
                        messageBox.Items.Add("");
                    }
                }
            }
            else {

                for (int i = 0; i < messagePrint.Length; i += 4)
                {
                    if (messagePrint.Length >= 4)
                    {
                        messageBox.Items.Add("-------------");
                        messageBox.Items.Add(messagePrint[1 + i] + " || " + messagePrint[i]);
                        messageBox.Items.Add(messagePrint[2 + i]);
                        messageBox.Items.Add("");
                    }
                }
            }
        }

        private void groupButtons_CheckedChanged(object button, EventArgs e)
        {
            if (((RadioButton)button).Checked)
            {
                newGchat = true;
                con.sendMessage("G"+((RadioButton)button).Text.Split(new char[] { '.' })[0]);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            con.sendMessage("M" + senderBox.Text);
            senderBox.Text = "";
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            con.endConnection();
            LogInPage form = new LogInPage();
            this.Close();
            form.Show();
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {

        }

        private void ClientPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClientPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
