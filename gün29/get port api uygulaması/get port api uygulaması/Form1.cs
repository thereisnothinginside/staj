using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_port_api_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_getData_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://192.168.1.1:5000/data"; // API URL

            try
            {
                // API'den veri al
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode(); 

                    string data = await response.Content.ReadAsStringAsync();
                    lbl_result.Text = $"Data: {data}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
