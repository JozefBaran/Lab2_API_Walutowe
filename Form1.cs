using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiWalutowe;

namespace GuiWalutowe

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string? data = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            var appId = "17c45a9d1b0a4d34acda9363b66acaae";
            var url = $"https://openexchangerates.org/api/historical/{data}.json?app_id={appId}";


            using (var Client = new HttpClient())
            {
                try
                {
                    var response = await Client.GetStringAsync(url);
                    var exchangeRates = JsonSerializer.Deserialize<ExchangeRatesResponse>(response);
                    textBox1.Text = response;
                    textBox1.AppendText(Environment.NewLine);
                    MessageBox.Show(exchangeRates.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}");
                }
            }


        }
    }
}