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

namespace ZatcaEInvoicing
{
    public partial class FrmProductionCSID : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public FrmProductionCSID()
        {
            InitializeComponent();
        }

        private async void btn_ProductionCSID_Click(object sender, EventArgs e)
        {
            FrmLoading loadingForm = new FrmLoading();
            loadingForm.Show();

            try
            {
                string apiUrl = "https://gw-fatoora.zatca.gov.sa/e-invoicing/developer-portal/production/csids";

                var username = "TUlJQ1BUQ0NBZU9nQXdJQkFnSUdBWXp6Z0VoTk1Bb0dDQ3FHU000OUJBTUNNQlV4RXpBUkJnTlZCQU1NQ21WSmJuWnZhV05wYm1jd0hoY05NalF3TVRFd01UTXhNVFUwV2hjTk1qa3dNVEE1TWpFd01EQXdXakIxTVFzd0NRWURWUVFHRXdKVFFURVdNQlFHQTFVRUN3d05VbWw1WVdSb0lFSnlZVzVqYURFbU1DUUdBMVVFQ2d3ZFRXRjRhVzExYlNCVGNHVmxaQ0JVWldOb0lGTjFjSEJzZVNCTVZFUXhKakFrQmdOVkJBTU1IVlJUVkMwNE9EWTBNekV4TkRVdE16azVPVGs1T1RrNU9UQXdNREF6TUZZd0VBWUhLb1pJemowQ0FRWUZLNEVFQUFvRFFnQUVvV0NLYTBTYTlGSUVyVE92MHVBa0MxVklLWHhVOW5QcHgydmxmNHloTWVqeThjMDJYSmJsRHE3dFB5ZG84bXEwYWhPTW1Obzhnd25pN1h0MUtUOVVlS09Cd1RDQnZqQU1CZ05WSFJNQkFmOEVBakFBTUlHdEJnTlZIUkVFZ2FVd2dhS2tnWjh3Z1p3eE96QTVCZ05WQkFRTU1qRXRWRk5VZkRJdFZGTlVmRE10WldReU1tWXhaRGd0WlRaaE1pMHhNVEU0TFRsaU5UZ3RaRGxoT0dZeE1XVTBORFZtTVI4d0hRWUtDWkltaVpQeUxHUUJBUXdQTXprNU9UazVPVGs1T1RBd01EQXpNUTB3Q3dZRFZRUU1EQVF4TVRBd01SRXdEd1lEVlFRYURBaFNVbEpFTWpreU9URWFNQmdHQTFVRUR3d1JVM1Z3Y0d4NUlHRmpkR2wyYVhScFpYTXdDZ1lJS29aSXpqMEVBd0lEU0FBd1JRSWhBSUY4akljeHp2Q3lxVURUcDVPbXY3MlVweFBBTG1vUnl0OURZMjRqV21CUUFpQTBiYVo2WXJwcDV5SjRhaG9vb1czK09hOGtrYjMxZXZBb0hkdmdEODA2M3c9PQ=="; // Replace with your actual username
                var password = "PKoGsSwpPx236yNS7CWDojV4doe1i0W+5mPodbMEW5k="; // Replace with your actual password
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);

                client.DefaultRequestHeaders.Add("Accept-Version", "V2");
                //client.DefaultRequestHeaders.Add("Accept-Language", "en");

                var requestData = new
                {
                    compliance_request_id = txt_ComplianceRequestID.Text,
                    
                };

                var jsonPayload = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);

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

                    //MessageBox.Show("Data retrieved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to make API call. Status code: {response.StatusCode}\nResponse: {responseContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FrmComplianceInvoiceAPI frm = new FrmComplianceInvoiceAPI();
            frm.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            FrmRenewalProductionCSID frm = new FrmRenewalProductionCSID();

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
