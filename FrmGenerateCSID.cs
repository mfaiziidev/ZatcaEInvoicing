using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace ZatcaEInvoicing
{
    public partial class FrmGenerateCSID : Form
    {
        public FrmGenerateCSID()
        {
            InitializeComponent();
        }

        private async void btn_GntCSID_Click(object sender, EventArgs e)
        {
            FrmLoading loadingForm = new FrmLoading();
            loadingForm.Show();

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("OTP", "123345");
                    client.DefaultRequestHeaders.Add("Accept-Version", "V2");

                    string jsonPayload = "{\"csr\":\"LS0tLS1CRUdJTiBDRVJUSUZJQ0FURSBSRVFVRVNULS0tLS0KTUlJQ0ZUQ0NBYndDQVFBd2RURUxNQWtHQTFVRUJoTUNVMEV4RmpBVUJnTlZCQXNNRFZKcGVXRmthQ0JDY21GdQpZMmd4SmpBa0JnTlZCQW9NSFUxaGVHbHRkVzBnVTNCbFpXUWdWR1ZqYUNCVGRYQndiSGtnVEZSRU1TWXdKQVlEClZRUUREQjFVVTFRdE9EZzJORE14TVRRMUxUTTVPVGs1T1RrNU9Ua3dNREF3TXpCV01CQUdCeXFHU000OUFnRUcKQlN1QkJBQUtBMElBQktGZ2ltdEVtdlJTQkswenI5TGdKQXRWU0NsOFZQWno2Y2RyNVgrTW9USG84dkhOTmx5Vwo1UTZ1N1Q4bmFQSnF0R29UakpqYVBJTUo0dTE3ZFNrL1ZIaWdnZWN3Z2VRR0NTcUdTSWIzRFFFSkRqR0IxakNCCjB6QWhCZ2tyQmdFRUFZSTNGQUlFRkF3U1drRlVRMEV0UTI5a1pTMVRhV2R1YVc1bk1JR3RCZ05WSFJFRWdhVXcKZ2FLa2daOHdnWnd4T3pBNUJnTlZCQVFNTWpFdFZGTlVmREl0VkZOVWZETXRaV1F5TW1ZeFpEZ3RaVFpoTWkweApNVEU0TFRsaU5UZ3RaRGxoT0dZeE1XVTBORFZtTVI4d0hRWUtDWkltaVpQeUxHUUJBUXdQTXprNU9UazVPVGs1Ck9UQXdNREF6TVEwd0N3WURWUVFNREFReE1UQXdNUkV3RHdZRFZRUWFEQWhTVWxKRU1qa3lPVEVhTUJnR0ExVUUKRHd3UlUzVndjR3g1SUdGamRHbDJhWFJwWlhNd0NnWUlLb1pJemowRUF3SURSd0F3UkFJZ1NHVDBxQkJ6TFJHOApJS09melI1L085S0VicHA4bWc3V2VqUlllZkNZN3VRQ0lGWjB0U216MzAybmYvdGo0V2FxbVYwN01qZVVkVnVvClJJckpLYkxtUWZTNwotLS0tLUVORCBDRVJUSUZJQ0FURSBSRVFVRVNULS0tLS0K\"}";
                    var requestBody = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                      
                    var response = await client.PostAsync("https://gw-fatoora.zatca.gov.sa/e-invoicing/developer-portal/compliance", requestBody);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);

                        string requestID = jsonResponse.requestID;
                        string dispositionMessage = jsonResponse.dispositionMessage;
                        string binarySecurityToken = jsonResponse.binarySecurityToken;
                        string secret = jsonResponse.secret;

                        txt_ReqID.Text = requestID;
                        txt_DopMsg.Text = dispositionMessage;
                        txt_GntCSID.Text = binarySecurityToken;
                        txt_SecretKey.Text = secret;
                    }
                    else
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to make API call. Status code: {response.StatusCode}\nResponse: {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                loadingForm.Close(); 
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            FrmComplianceInvoiceAPI frm = new FrmComplianceInvoiceAPI();

            if (txt_DopMsg.Text == "" || txt_GntCSID.Text == "" || txt_ReqID.Text == "" || txt_SecretKey.Text == "")
            {
                MessageBox.Show("Please generate CSID first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frm.Show();
                this.Hide();
            }
            
            
        }
    }
}
