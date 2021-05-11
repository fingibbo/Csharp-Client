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
        private static System.Timers.Timer chatUpdateTimer = new System.Timers.Timer(750);
        private string[][] groupData;
        private string currentGroup;

        public ClientPage()
        {
            InitializeComponent();
            con.sendMessage("UGL");
            groupSorter(); 
            chatUpdateTimer.Elapsed += new ElapsedEventHandler(updateCheck);
            //chatUpdateTimer.Start();


        }
        private void updateCheck(object source, ElapsedEventArgs e)
        {
            con.sendMessage("UGL");
            groupSorter();
            con.sendMessage("UGD");
        }

        private void groupSorter()
        {
            string[] data = con.getMessage().Split(new char[]{ ':', ',' });
            string[][] postData = new string[data.Length/2][];
            for(int i = 0; i < data.Length; i+=2)
            {
                postData[i/2] = new string[2];
                postData[i/2][0] = data[i];
                postData[i / 2][1] = data[i + 1];
            }

            for(int i = 0; i <  postData.Length; i++)
            {

                //groupListBox.Items.Add(postData[i][1]);
            }

            groupData = postData;
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            con.sendMessage("M" + senderBox.Text);
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
