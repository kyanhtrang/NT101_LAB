using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Client : Form
    {
        IPEndPoint IPServer;
        //TcpClient client;
        Socket client;

        private string otherPublicKey = string.Empty;
        private string myPublicKey = string.Empty;
        private string privateKey = string.Empty;
        private RSA newRSA;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btnConnect.Enabled = false;
            btnSend.Enabled = false;
            tbMessageText.Enabled = false;
            CreateNewKeys();
        }

        void AddMessage(string s)
        {
            lvMessageShow.Items.Add(new ListViewItem() { Text = s });
            tbMessageText.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //btnSend.Enabled = true;
            tbMessageText.Enabled = true;
            IPServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IPServer);
                Thread listen = new Thread(new ThreadStart(Receive));
                listen.IsBackground = true;
                listen.Start();
                SendConnection();

                SendPublicKey();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        void SendConnection()
        {
            byte[] data = Encoding.Unicode.GetBytes(tbNameInput.Text + " is connected to the server");
            client.Send(data);
            tbMessageText.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(tbMessageText.Text);
        }

        void SendPublicKey()
        {
            if (myPublicKey != string.Empty)
            {
                byte[] data1 = System.Text.Encoding.Unicode.GetBytes("Key " + tbNameInput.Text + ":" + myPublicKey);
                client.Send(data1);
                tbMessageText.Text = "";
            }
        }
        void Send(string str)
        {
            if (str != string.Empty)
            {
                //string s = ComputeSha256Hash(str);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    byte[] data1 = System.Text.Encoding.Unicode.GetBytes(tbNameInput.Text + ":" + str);

                    //MessageBox.Show(tbNameInput.Text + "is using public key = " + otherPublicKey);
                    RSA.FromXmlString(otherPublicKey);
                    byte[] encryptedV1 = RSA.Encrypt(data1, false);
                    //byte[] data1 = System.Text.Encoding.Unicode.GetBytes(tbNameInput.Text + ":" + str);
                    client.Send(encryptedV1);
                    tbMessageText.Text = "";
                    lvMessageShow.Items.Add(new ListViewItem() { Text = tbNameInput.Text + ":" + str });
                }

            }
        }

        string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        void Receive()
        {
            while (true)
            {
                byte[] data = new byte[1024 * 5000];
                client.Receive(data);

                string message = Encoding.Unicode.GetString(data);

                if (string.IsNullOrEmpty(message) == false)
                {
                    if (message.Contains("is connected to the server") == true)
                    {
                        AddMessage(message);
                    }
                    else
                    {
                        if (message.Contains("<RSAKeyValue>") && message.Contains("<Modulus>"))
                        {
                            if (checkServerSendKey(message) == false)
                            {
                                AddMessage(message);
                            }
                            else
                                AddMessage(tbNameInput.Text + ": " + otherPublicKey);
                        }
                        else
                        {
                            MessageBox.Show("Get into a normal messange area ");
                            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                            {
                                byte[] realData = new byte[128];
                                Array.Copy(data, realData, 128);

                                byte[] decryptedV1;
                                RSA.FromXmlString(privateKey);
                                decryptedV1 = RSA.Decrypt(realData, false);
                                AddMessage(Encoding.Unicode.GetString(decryptedV1));
                            }
                        }
                    }
                }
            }
        }
        bool checkServerSendKey(string mess)
        {
            if (mess.StartsWith(tbNameInput.Text) == false)
            {
                int index = mess.IndexOf(":");
                otherPublicKey = mess.Substring(index + 1);

                //MessageBox.Show(tbNameInput.Text + " already get key =" + otherPublicKey);
                //tbReceivePU.Text += otherPublicKey;
                return true;
            }
            return false;
        }
        private void CreateNewKeys()
        {
            newRSA = new RSACryptoServiceProvider();
            myPublicKey = newRSA.ToXmlString(false);
            privateKey = newRSA.ToXmlString(true);
            //tbPUKey.Text += myPublicKey;
            //tbPRKey.Text += privateKey;
        }

        private void tbNameInput_TextChanged(object sender, EventArgs e)
        {
            this.btnConnect.Enabled = !string.IsNullOrWhiteSpace(this.tbNameInput.Text);
        }

        private void tbMessageText_TextChanged(object sender, EventArgs e)
        {
            this.btnSend.Enabled = !string.IsNullOrWhiteSpace(this.tbMessageText.Text);
        }
    }
}
