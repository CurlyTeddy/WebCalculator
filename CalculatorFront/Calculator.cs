using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CalculatorFront
{
    public partial class Calculator : Form
    {
        private HttpClient client = new HttpClient();
        private HttpRequestMessage request;
        private HttpResponseMessage response;

        public Calculator()
        {
            InitializeComponent();
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            request = new HttpRequestMessage(new HttpMethod("Post"), "http://localhost:58001/api/values");
            request.Content = new StringContent(button.Tag.ToString(), Encoding.UTF8, "application/json");
            response = await client.SendAsync(request);
            Stream stream = await response.Content.ReadAsStreamAsync();
            
            using (StreamReader streamReader = new StreamReader(stream))
            {
                using (JsonTextReader Json = new JsonTextReader(streamReader))
                {
                    JsonSerializer JsonParser = new JsonSerializer();
                    string[] result = JsonParser.Deserialize<string[]>(Json);
                    Equation.Text = result[0];
                    Result.Text = result[1];
                }
            }
            request.Dispose();
        }
    }
}
