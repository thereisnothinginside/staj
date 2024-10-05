using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace port_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            Invoke((MethodInvoker)(() => label1.Text = "Sunucu 5000 portunda dinliyor..."));

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Invoke((MethodInvoker)(() => label1.Text += Environment.NewLine + "Bir istemci bağlandı."));

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                Invoke((MethodInvoker)(() => label1.Text += Environment.NewLine + "Gelen JSON verisi: " + jsonData));

                string responseMessage = "var data = new\r\n{\r\n    Name = \"hüseyin\",\r\n    Message = \"Hello, this is a JSON message!\",\r\n    Timestamp = DateTime.Now\r\n};";
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage);
                stream.Write(responseBytes, 0, responseBytes.Length);

                client.Close();
            }
        }
    }
}
