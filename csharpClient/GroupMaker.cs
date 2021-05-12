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
    public partial class GroupMaker : Form
    {
        Connection con = new Connection();
        public GroupMaker()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            con.sendMessage("C" + con.noPunc(groupNamerBox.Text));
            this.Close();
        }
    }
}
