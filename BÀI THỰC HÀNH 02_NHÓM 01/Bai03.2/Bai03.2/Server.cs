using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Collections;

namespace Bai03._2
{
    public partial class Server : Form
    {
        TcpListener server;
        Socket client;
        IPEndPoint IPE;
        List<Socket> clientList = new List<Socket>();

        public ArrayList publicKeyList = new ArrayList();
        public ArrayList usernameList = new ArrayList();
        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            IPE = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            server = new TcpListener(IPE);
            AddMessage("Server running on " + IPE.ToString());
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    server.Start();
                    client = server.AcceptSocket();
                    clientList.Add(client);
                    //AddMess("New client connected from: " + client.RemoteEndPoint);
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
      
        void Receive(object obj)
        {
            try
            {
                while (true)
                {

                    Socket client = obj as Socket;
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = Encoding.Unicode.GetString(data);

                    if (message.Contains("<RSAKeyValue>") && message.Contains("<Modulus>"))
                    {
                        //MessageBox.Show("server receive:" + message);
                        string header = message.Substring(0, 3);
                        //MessageBox.Show("server receive header:" + header);
                        if (header.Equals("Key") == true)
                        {
                            int firstColonIndex = message.IndexOf(":");
                            string name = message.Substring(3, firstColonIndex - 3);
                            string publicKey = message.Substring(firstColonIndex + 1);
                            usernameList.Add(name);
                            publicKeyList.Add(publicKey);
                        }
                        AddMessage(message);
                    }
                    else
                        SendtoAnotherSocket(data, client);

                    int numberOfUser = publicKeyList.Count;
                    if (numberOfUser == 2)
                    {
                        string shareKey = usernameList[0].ToString() + ":" + publicKeyList[0].ToString();
                        String shareKey2 = usernameList[1].ToString() + ":" + publicKeyList[1].ToString();
                        byte[] keybyte = Encoding.Unicode.GetBytes(shareKey);
                        byte[] keybyte2 = Encoding.Unicode.GetBytes(shareKey2);
                        //MessageBox.Show(shareKey);
                        Broadcast(keybyte);

                        Thread.Sleep(50);
                       // MessageBox.Show(shareKey2);
                        Broadcast(keybyte2);
                        //add another key to public key list to ++ number of user to 3 in order next loop no not check this if else
                        publicKeyList.Add("anotherKey");
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void Broadcast(byte[] data)
        {
            foreach (Socket sk in clientList)
            {
                sk.Send(data);
            }
            string message = Encoding.Unicode.GetString(data);
            AddMessage(message);
        }

        private void SendtoAnotherSocket(byte[] data, Socket currentListeningSocket)
        {
            foreach (Socket sk in clientList)
            {
                if (currentListeningSocket.Equals(sk) != true)
                {
                    sk.Send(data);
                }
            }
            string message = Encoding.Unicode.GetString(data);
            AddMessage(message);
        }
        void AddMessage(string s)
        {
            tbMessageShow.Items.Add(new ListViewItem() { Text = s });
        }
    }
}
