using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpClient
{
    public partial class ClientPage : Form
    {
        Connection con = new Connection();

        public ClientPage()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            con.sendMessage("M" + messageBox.Text);
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
