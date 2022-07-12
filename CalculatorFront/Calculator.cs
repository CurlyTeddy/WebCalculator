using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Text;
using Newtonsoft.Json.Linq;

namespace CalculatorFront
{
    public partial class Calculator : Form
    {
        private HttpClient client = new HttpClient();
        private HttpRequestMessage request;
        private HttpResponseMessage response;
        private Uri uri;
        private int? identifier;

        public Calculator()
        {
            InitializeComponent();
            // Not necessary to add header
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            uri = new Uri("http://localhost:58001/api/values");
            identifier = new Random(Guid.NewGuid().GetHashCode()).Next();
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            request = new HttpRequestMessage(new HttpMethod("Post"), uri);
            // Specification of encoding and media type is necessary
            request.Content = new StringContent($"{{ \"button\": {button.Tag.ToString()}, \"ID\": {identifier} }}", Encoding.UTF8, "application/json");
            response = await client.SendAsync(request);
            Stream stream = await response.Content.ReadAsStreamAsync();
            
            if (response.IsSuccessStatusCode)
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    using (JsonTextReader Json = new JsonTextReader(streamReader))
                    {
                        JsonSerializer JsonParser = new JsonSerializer();
                        JObject result = (JObject)JsonParser.Deserialize(Json);
                        Equation.Text = result["CurrentEquation"].ToString();
                        Result.Text = result["Result"].ToString();
                    }
                }
            }
            else if(response.StatusCode == HttpStatusCode.BadRequest)
            {
                MessageBox.Show($"僅能刪除當前數字");
            }
            request.Dispose();
        }

        private async void CloseClick(object sender, EventArgs e)
        {
            request = new HttpRequestMessage(new HttpMethod("Delete"), uri + $"/{identifier}");
            response = await client.SendAsync(request);
        }
    }
}
