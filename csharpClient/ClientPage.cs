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

        public ClientPage()
        {
            InitializeComponent();
            con.sendMessage("UGL");
            groupSorter(); 
            chatUpdateTimer.Elapsed += new ElapsedEventHandler(updateCheck);
            chatUpdateTimer.Start();


        }
        private void updateCheck(object source, ElapsedEventArgs e)
        {
            con.sendMessage("UGD");
        }

        private void groupSorter()
        {
            messageBox.Items.Add(con.getMessage());
            con.sendMessage("G1");
            con.sendMessage("UGD");

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
    }
}
