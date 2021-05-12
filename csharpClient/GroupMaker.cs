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

        private string noPunc(string name)
        {
            string groupName;
            var sb = new StringBuilder();
            
            foreach (char c in name)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            groupName = sb.ToString();
            return groupName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            con.sendMessage("C" + noPunc(groupNamerBox.Text));
        }
    }
}
