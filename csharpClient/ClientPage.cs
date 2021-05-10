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
        public ClientPage()
        {
            InitializeComponent();
        }

        public void msgSender(string toSend)
        {
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            //clientSocket.Send(toSendLenBytes);
            //clientSocket.Send(toSendBytes);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            msgSender("M" + messageBox.Text);
        }
    }
}
