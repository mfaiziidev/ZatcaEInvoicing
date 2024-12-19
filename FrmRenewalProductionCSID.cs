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
using Newtonsoft.Json;
using System.Net;

namespace ZatcaEInvoicing
{
    public partial class FrmRenewalProductionCSID : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public FrmRenewalProductionCSID()
        {
            InitializeComponent();
        }

        private async void btn_ProductionCSID_Click(object sender, EventArgs e)
        {
            FrmLoading loadingForm = new FrmLoading();
            loadingForm.Show();

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Ensure TLS 1.2 is used
                string apiUrl = "https://gw-fatoora.zatca.gov.sa/e-invoicing/developer-portal/production/csids";

                var username = "TUlJRDREQ0NBNGFnQXdJQkFnSVRmd0FBTnN5aERKZ3FsbVU5YmdBQkFBQTJ6REFLQmdncWhrak9QUVFEQWpCaU1SVXdFd1lLQ1pJbWlaUHlMR1FCR1JZRmJHOWpZV3d4RXpBUkJnb0praWFKay9Jc1pBRVpGZ05uYjNZeEZ6QVZCZ29Ka2lhSmsvSXNaQUVaRmdkbGVIUm5ZWHAwTVJzd0dRWURWUVFERXhKUVVscEZTVTVXVDBsRFJWTkRRVEl0UTBFd0hoY05NalF3TVRFMU1UY3hOelEyV2hjTk1qa3dNVEV6TVRjeE56UTJXakIxTVFzd0NRWURWUVFHRXdKVFFURW1NQ1FHQTFVRUNoTWRUV0Y0YVcxMWJTQlRjR1ZsWkNCVVpXTm9JRk4xY0hCc2VTQk1WRVF4RmpBVUJnTlZCQXNURFZKcGVXRmthQ0JDY21GdVkyZ3hKakFrQmdOVkJBTVRIVlJUVkMwNE9EWTBNekV4TkRVdE16azVPVGs1T1RrNU9UQXdNREF6TUZZd0VBWUhLb1pJemowQ0FRWUZLNEVFQUFvRFFnQUU1VlA5ZFFXbmtpNHpSZ1VZanBORDRBdVZVNFhBVmFxc0piVlR2ZEtJOUVJZHpvSlRGRENXSEdiR0ZOemtZUDB5b05MdG8vNS84MFlEQjV2TkZ1Z1hhS09DQWdrd2dnSUZNSUd2QmdOVkhSRUVnYWN3Z2FTa2dhRXdnWjR4T3pBNUJnTlZCQVFNTWpFdFZGTlVmREl0VkZOVWZETXRaV1F5TW1ZeFpEZ3RaVFpoTWkweE1URTRMVGxpTlRndFpEbGhPR1l4TVdVME5EVm1NUjh3SFFZS0NaSW1pWlB5TEdRQkFRd1BNems1T1RrNU9UazVPVEF3TURBek1RMHdDd1lEVlFRTURBUXhNVEF3TVJFd0R3WURWUVFhREFoU1VsSkVNamt5T1RFY01Cb0dBMVVFRHd3VDJZMVRkWEJ3YkhrZ1lXTjBhWFpwZEdsbGN6QWRCZ05WSFE0RUZnUVVadkJOcHdmMFJzWTBvU2QyWXo2Tjg0aXhCRll3SHdZRFZSMGpCQmd3Rm9BVVdjaHlubmsxYWVxODJaWFUxK0JrYVFJR0VCa3dld1lJS3dZQkJRVUhBUUVFYnpCdE1Hc0dDQ3NHQVFVRkJ6QUNobDlvZEhSd09pOHZZV2xoTWk1NllYUmpZUzVuYjNZdWMyRXZRMlZ5ZEVWdWNtOXNiQzlRVWxwRmFXNTJiMmxqWlZORFFUSXVaWGgwWjJGNmRDNW5iM1l1Ykc5allXeGZVRkphUlVsT1ZrOUpRMFZUUTBFeUxVTkJLREVwTG1OeWREQU9CZ05WSFE4QkFmOEVCQU1DQjRBd1BBWUpLd1lCQkFHQ054VUhCQzh3TFFZbEt3WUJCQUdDTnhVSWdZYW9IWVRRK3hLRzdaMGtoODc3R2RQQVZXYUgrcVZsaGRtRVBnSUJaQUlCRWpBZEJnTlZIU1VFRmpBVUJnZ3JCZ0VGQlFjREF3WUlLd1lCQlFVSEF3SXdKd1lKS3dZQkJBR0NOeFVLQkJvd0dEQUtCZ2dyQmdFRkJRY0RBekFLQmdnckJnRUZCUWNEQWpBS0JnZ3Foa2pPUFFRREFnTklBREJGQWlBbXpvcU4xckN5MTJMMURtTTc1NUU3RC9TdUJFRzNlankzU3FrMkZhN2Ezd0loQUprS0YwcFgzYzFPWjF6WjVwOXdLekJHVExSZmx6MmQzWDlQN3BPRGJFT1I=";
                var password = "epycRKns8eYW6i35KmPs3xga4A9z2pdBFK7UcMjJmG0=";
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                client.DefaultRequestHeaders.Add("Accept-Version", "V2");
                client.DefaultRequestHeaders.Add("Accept-Language", "en");
                client.DefaultRequestHeaders.Add("OTP", "123456");

                var requestData = new
                {
                    csr = txt_CSR.Text,
                };

                var jsonPayload = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Create a new HttpRequestMessage for PATCH
                var request = new HttpRequestMessage(new HttpMethod("PATCH"), apiUrl)
                {
                    Content = content
                };

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);

                    string requestID = jsonResponse.requestID;
                    string dispositionMessage = jsonResponse.dispositionMessage;
                    string binarySecurityToken = jsonResponse.binarySecurityToken;
                    string secret = jsonResponse.secret;

                    txt_RequestID.Text = requestID;
                    txt_DipositationMsg.Text = dispositionMessage;
                    txt_BinarySecurityToken.Text = binarySecurityToken;
                    txt_Secret.Text = secret;
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to make API call. Status code: {response.StatusCode}\nResponse: {responseContent}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"HTTP error: {httpEx.Message}", "HTTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadingForm.Close();
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmProductionCSID frm = new FrmProductionCSID();
            frm.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            FrmReporting frm = new FrmReporting();

            if (txt_Secret.Text == "" || txt_DipositationMsg.Text == "" || txt_RequestID.Text == "" || txt_BinarySecurityToken.Text == "")
            {
                MessageBox.Show("Please generate Production CSID first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frm.Show();
                this.Hide();
            }
        }
    }
}
