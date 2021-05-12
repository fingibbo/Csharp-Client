using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace csharpClient
{

    class Connection
    {
        //sets variables for connecting to the server java socket
        public static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static IPEndPoint serverAddress;
        public static bool running = false;

        //connects to server
        public bool createConnection(String ip, int port)
        {
            //takes inputted ip and port to connect to the server
            serverAddress = new IPEndPoint(IPAddress.Parse(ip), port);
            clientSocket.Connect(serverAddress);
            clientSocket.ReceiveTimeout = 3000;
            //sets the server connected as true
            running = true;
            return true;
        }

        //way to check is server is running
        public bool isRunning()
        {
            return running;
        }

        //disconnects from server by settings running to false and closing the socket
        public void endConnection()
        {
            running = false;
            clientSocket.Close();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        //sends messages
        public void sendMessage(string toSend)
        {
            //tenor since sending an apostraphe causes errors, it doesnt send one.
            string temp = toSend;
            string forSend = temp.Trim('\'');
            if (temp == forSend)
            {
                //converts the text to send to bytes
                int toSendLen = System.Text.Encoding.ASCII.GetByteCount(forSend);
                byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(forSend);
                byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
                //sends the message
                clientSocket.Send(toSendLenBytes);
                clientSocket.Send(toSendBytes);
            }
            else
            {

            }

        }

        //gets messages from the server
        public string getMessage()
        {
            //receives message and message length in byes from server
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            //converts to bytes to string
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);
            //prints message
            return rcv.Normalize();
        }

        //removes punctuation from a string
        public string noPunc(string name)
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

    }
}