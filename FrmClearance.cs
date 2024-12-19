using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using QRCoder;


namespace ZatcaEInvoicing
{
    public partial class FrmClearance : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public FrmClearance()
        {
            InitializeComponent();
        }

        private async void btn_ClearInvoice_Click(object sender, EventArgs e)
        {
            FrmLoading loadingForm = new FrmLoading();
            loadingForm.Show();
        
            try
            {
                using (var client = new HttpClient())
                {
                    string apiUrl = "https://gw-fatoora.zatca.gov.sa/e-invoicing/developer-portal/invoices/clearance/single";


                    string oauthToken = "VFVsSlJETnFRME5CTkZOblFYZEpRa0ZuU1ZSRlVVRkJUMEZRUmprd1FXcHpMM2hqV0hkQlFrRkJRVFJCZWtGTFFtZG5jV2hyYWs5UVVWRkVRV3BDYVUxU1ZYZEZkMWxMUTFwSmJXbGFVSGxNUjFGQ1IxSlpSbUpIT1dwWlYzZDRSWHBCVWtKbmIwcHJhV0ZLYXk5SmMxcEJSVnBHWjA1dVlqTlplRVo2UVZaQ1oyOUthMmxoU21zdlNYTmFRVVZhUm1ka2JHVklVbTVaV0hBd1RWSnpkMGRSV1VSV1VWRkVSWGhLVVZWc2NFWlRWVFZYVkRCc1JGSldUa1JSVkZGMFVUQkZkMGhvWTA1TmFsRjNUVlJGZUUxRWEzaFBWRTEzVjJoalRrMXFhM2ROVkVFMVRVUnJlRTlVVFhkWGFrSXhUVkZ6ZDBOUldVUldVVkZIUlhkS1ZGRlVSVzFOUTFGSFFURlZSVU5vVFdSVVYwWTBZVmN4TVdKVFFsUmpSMVpzV2tOQ1ZWcFhUbTlKUms0eFkwaENjMlZUUWsxV1JWRjRSbXBCVlVKblRsWkNRWE5VUkZaS2NHVlhSbXRoUTBKRFkyMUdkVmt5WjNoS2FrRnJRbWRPVmtKQlRWUklWbEpVVmtNd05FOUVXVEJOZWtWNFRrUlZkRTE2YXpWUFZHczFUMVJyTlU5VVFYZE5SRUY2VFVaWmQwVkJXVWhMYjFwSmVtb3dRMEZSV1VaTE5FVkZRVUZ2UkZGblFVVnZWME5MWVRCVFlUbEdTVVZ5VkU5Mk1IVkJhME14VmtsTFdIaFZPVzVRY0hneWRteG1OSGxvVFdWcWVUaGpNREpZU21Kc1JIRTNkRkI1Wkc4NGJYRXdZV2hQVFcxT2J6aG5kMjVwTjFoME1VdFVPVlZsUzA5RFFXZGpkMmRuU1VSTlNVZDBRbWRPVmtoU1JVVm5ZVlYzWjJGTGEyZGFPSGRuV25kNFQzcEJOVUpuVGxaQ1FWRk5UV3BGZEZaR1RsVm1SRWwwVmtaT1ZXWkVUWFJhVjFGNVRXMVplRnBFWjNSYVZGcG9UV2t3ZUUxVVJUUk1WR3hwVGxSbmRGcEViR2hQUjFsNFRWZFZNRTVFVm0xTlVqaDNTRkZaUzBOYVNXMXBXbEI1VEVkUlFrRlJkMUJOZW1zMVQxUnJOVTlVYXpWUFZFRjNUVVJCZWsxUk1IZERkMWxFVmxGUlRVUkJVWGhOVkVGM1RWSkZkMFIzV1VSV1VWRmhSRUZvVTFWc1NrVk5hbXQ1VDFSRllVMUNaMGRCTVZWRlJIZDNVbFV6Vm5kalIzZzFTVWRHYW1SSGJESmhXRkp3V2xoTmQwaFJXVVJXVWpCUFFrSlpSVVpGV0N0WmRtMXRkRzVaYjBSbU9VSkhZa3R2TjI5alZFdFpTekZOUWpoSFFURlZaRWwzVVZsTlFtRkJSa3AyUzNGeFRIUnRjWGR6YTBsR2VsWjJjRkF5VUhoVUt6bE9iazFJYzBkRFEzTkhRVkZWUmtKM1JVSkNSemgzWWxSQ2NrSm5aM0pDWjBWR1FsRmpkMEZ2V21aaFNGSXdZMFJ2ZGt3eVJuQlpWRkYxWlcxR01Ga3lSWFZhTWpreVRHNU9hRXd3VG14amJsSkdZbTVLZG1KSGQzWlZSa3BoVWxWc2RXUnRPWEJaTWxaVVVUQkZNRXh0VmpSa1IyUm9aVzVSZFZveU9USk1iWGgyV1RKR2MxZ3hRbE5YYTFaS1ZHeGFVRk5WVGtaVk1FNUNUa014UkZGVFozaExVelZxWTI1UmQwUm5XVVJXVWpCUVFWRklMMEpCVVVSQloyVkJUVVIzUjBOVGMwZEJVVkZDWjJwalZrSjNVWFpOUXpCSFNsTnpSMEZSVVVKbmFtTldRMGxIUjNGQ01rVXdVSE5UYUhVeVpFcEpaazhyZUc1VWQwWldiV2d2Y1d4YVdWaGFhRVEwUTBGWFVVTkJVa2wzU0ZGWlJGWlNNR3hDUWxsM1JrRlpTVXQzV1VKQ1VWVklRWGROUjBORGMwZEJVVlZHUW5kTlEwMURZMGREVTNOSFFWRlJRbWRxWTFaRFoxRmhUVUpuZDBObldVbExkMWxDUWxGVlNFRjNUWGREWjFsSlMzZFpRa0pSVlVoQmQwbDNRMmRaU1V0dldrbDZhakJGUVhkSlJGTkJRWGRTVVVsb1FVeEZMMmxqYUcxdVYxaERWVXRWWW1OaE0zbGphVGh2Y1hkaFRIWkdaRWhXYWxGeWRtVkpPWFZ4UVdKQmFVRTVhRU0wVFRocVowMUNRVVJRVTNwdFpESjFhVkJLUVRablMxSXpURVV3TTFVM05XVnhZa012Y2xoQlBUMD06Q2tZc0VYZlY4YzFnRkhBdEZXb1p2NzNwR012aC9ReW80THpLTTJoLzhIZz0=";

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", oauthToken);
                    client.DefaultRequestHeaders.Add("Accept-Version", "V2");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en");
                    client.DefaultRequestHeaders.Add("Clearance-Status", "1");

                    var requestData = new
                    {
                        invoiceHash = txt_InvoiceHash.Text,
                        uuid = txt_UUID.Text,
                        invoice = txt_Invoice.Text
                    };

                    var jsonPayload = JsonConvert.SerializeObject(requestData);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);

                        string validationStatus = jsonResponse.validationResults.status;
                        string clearanceStatus = jsonResponse.clearanceStatus;
                        string clearedInvoice = jsonResponse.clearedInvoice;

                        var infoMessages = jsonResponse.validationResults.infoMessages;
                        var warningMessages = jsonResponse.validationResults.warningMessages;
                        

                        txt_Status.Text = validationStatus;
                        txt_ClearingStatus.Text = clearanceStatus;
                        txt_ClearedInvoice.Text = clearedInvoice;
                        GenerateQRCode(clearedInvoice);

                        StringBuilder messageBuilder = new StringBuilder("Info Messages:\n");
                        foreach (var message in infoMessages)
                        {
                            messageBuilder.AppendLine($"{message.code}: {message.message}");
                        }

                        if (warningMessages.Count > 0)
                        {
                            messageBuilder.AppendLine("\nWarning Messages:\n");
                            foreach (var message in warningMessages)
                            {
                                messageBuilder.AppendLine($"{message.code}: {message.message}");
                            }
                        }

                        //MessageBox.Show(messageBuilder.ToString(), "API Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to make API call. Status code: {response.StatusCode}\nResponse: {responseContent}");
                    }
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
            FrmClearance frm = new FrmClearance();
            frm.Show();
            this.Hide();
        }
        private void GenerateQRCode(string text)
        {
             string encryptionKey = "12345678901234567890123456789012"; // Must be 32 bytes for AES
            string encryptedData = EncryptString(text, encryptionKey);

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(encryptedData, QRCodeGenerator.ECCLevel.L);
                QRCode qrCode = new QRCode(qrCodeData);
                pictureBoxQRCode.Image = qrCode.GetGraphic(20); // Adjust the size as needed
            }
        }
        private static string EncryptString(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.GenerateIV();

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private static string DecryptString(string cipherText, string key)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                byte[] iv = new byte[aes.IV.Length];
                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                byte[] cipher = new byte[fullCipher.Length - iv.Length];
                Array.Copy(fullCipher, iv.Length, cipher, 0, cipher.Length);

                using (var decryptor = aes.CreateDecryptor(aes.Key, iv))
                using (var ms = new MemoryStream(cipher))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

    }
}
