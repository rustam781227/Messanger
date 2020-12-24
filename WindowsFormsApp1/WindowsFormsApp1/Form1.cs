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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string TextToSend;
        public string fileName;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPorttextBox.Text));
            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    ChatScreentextBox.AppendText("Connected to Server" + Environment.NewLine);
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextBox.AppendText("You: " + receive + Environment.NewLine);
                    }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreentextBox.AppendText("Me: " + TextToSend + Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }
    }
}
