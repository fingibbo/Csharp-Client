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
        public static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static IPEndPoint serverAddress;
        private static System.Timers.Timer pingTimer = new System.Timers.Timer(1000);
        public static bool running = false;

        public bool createConnection(String ip, int port)
        {
            serverAddress = new IPEndPoint(IPAddress.Parse(ip), port);
            clientSocket.Connect(serverAddress);
            pingTimer.Elapsed += new ElapsedEventHandler(doPing);
            pingTimer.Start();
            running = true;
            return true;
        }


        public bool isRunning()
        {
            return running;
        }

        public void endConnection()
        {
            running = false;
            pingTimer.Stop();
            clientSocket.Close();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void sendMessage(string toSend)
        {
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }

        public string getMessage()
        {
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);
            return rcv.Normalize();
        }

        private void doPing(object source, ElapsedEventArgs e)
        {
            sendMessage("hh");
        }

    }
}