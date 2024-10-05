using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace api_sayı_üretici
{
    public partial class Form1 : Form
    {
        private Timer timer; 

        private Random random = new Random();
        private string randomValue;
        public Form1()
        {
            InitializeComponent();
            StartServer(); 
            SetupTimer(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetupTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += (sender, e) => GenerateRandomNumber(); 
            timer.Start();
        }

        private void GenerateRandomNumber()
        {
            randomValue = random.Next(1, 100).ToString(); 
            label1.Text = randomValue; 
        }

        private async void StartServer()
        {
            using (var listener = new HttpListener())
            {
                listener.Prefixes.Add("http://localhost:8080/");
                listener.Start();

                while (true)
                {
                    var context = await listener.GetContextAsync();
                    var request = context.Request;
                    var response = context.Response;

                    if (request.HttpMethod == "GET")
                    {
                        var responseString = $"{{\"value\":\"{randomValue}\"}}";
                        var buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        using (var output = response.OutputStream)
                        {
                            await output.WriteAsync(buffer, 0, buffer.Length);
                        }
                    }

                    response.Close();
                }
            }
        }


    }
}




