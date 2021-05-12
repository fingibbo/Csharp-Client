using System;
using System.Windows.Forms;

namespace csharpClient
{
    public partial class AddUserForm : Form
    {
        Connection con = new Connection();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            con.sendMessage("V" + idNoBox.Text + "-" +usernameBox.Text);
            int response = Int32.Parse(con.getMessage());
            if (response == 1)
            {
                con.sendMessage("A" + idNoBox.Text);
                idNoBox.Text = "";
                usernameBox.Text = "";
            }
            else
            {
                errorLabel.Text = "The username or ID is incorrect.";
            }
        }
    }
}
