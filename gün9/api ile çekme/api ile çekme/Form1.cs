using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;




namespace api_ile_çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var number = await GetRandomNumber();
            label1.Text = number;
        }

        private async Task<string> GetRandomNumber()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = "http://127.0.0.1:5000/";
                    var response = await client.GetStringAsync(apiUrl);
                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);
                    return "Hata";
                }
            }
        }
    }
}
