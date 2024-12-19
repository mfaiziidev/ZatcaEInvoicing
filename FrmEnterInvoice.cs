using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using UblSharp;
using System.Collections.Generic;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;
using System.Xml.Serialization;




namespace ZatcaEInvoicing
{
    public partial class FrmEnterInvoice : Form
    {
        private int SaleInvoiceID;
        private int TaxInvoiceID;

        public FrmEnterInvoice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            txtInvoiceRefNo.Text = "ZET-";
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbInvoiceType.Text == "Sale Invoice")
            {
                SaleInvoiceID = 0;
            }
            if (cmbInvoiceType.Text == "Tax Invoice")
            {
                SaleInvoiceID = 1;
            }

            SqlConnection con = new SqlConnection(ConnectionDB.connection);
            SqlCommand cmd = new SqlCommand("USP_InsertInvoice", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UnitPrice", dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString());
            cmd.Parameters.AddWithValue("@SubTotal", dataGridView1.CurrentRow.Cells["SubTotal"].Value.ToString());
            cmd.Parameters.AddWithValue("@VATPerc", dataGridView1.CurrentRow.Cells["VATPerc"].Value.ToString());
            cmd.Parameters.AddWithValue("@InvoiceRefNo", txtInvoiceRefNo.Text);
            cmd.Parameters.AddWithValue("@BusinessType", cmbInvoiceType.Text);
            cmd.Parameters.AddWithValue("@SellerCompanyName", txtSellerCompanyName.Text);
            cmd.Parameters.AddWithValue("@SellerCompanyAddress", txtSellerCompanyAddress.Text);
            cmd.Parameters.AddWithValue("@SellerVatID", txtSellerVatID.Text);
            cmd.Parameters.AddWithValue("@BuyerCompanyName", txtBuyerCompanyName.Text);
            cmd.Parameters.AddWithValue("@BuyerCompanyAddress", txtBuyerCompanyAddress.Text);
            cmd.Parameters.AddWithValue("@BuyerVatID", txtBuyerVatID.Text);
            cmd.Parameters.AddWithValue("@ItemName", dataGridView1.CurrentRow.Cells["ItemName"].Value.ToString());
            cmd.Parameters.AddWithValue("@DateTime", DateTimePicker.Value);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data Has Been Saved Successfully!");
        }

        private void btnSubTotal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                UpdateSubTotal(i);
            }
        }

        private void UpdateSubTotal(int rowIndex)
        {
            decimal totalSubTotal = 0;
            decimal totalVATAmount = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int unitPrice = Convert.ToInt32(dataGridView1.Rows[i].Cells["UnitPrice"].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                int VAT = Convert.ToInt32(dataGridView1.Rows[i].Cells["VATPerc"].Value);

                decimal subTotal = unitPrice * quantity;
                decimal VATAmount = (subTotal * VAT) / 100;
                decimal totalAmount = subTotal + VATAmount;

                dataGridView1.Rows[i].Cells["SubTotal"].Value = subTotal.ToString();
                dataGridView1.Rows[i].Cells["VATAmount"].Value = VATAmount.ToString();

                totalSubTotal += subTotal;
                totalVATAmount += VATAmount;
            }

            txtTotal.Text = totalSubTotal.ToString();
            txtVatAmount.Text = totalVATAmount.ToString();
            txtNetTotal.Text = (totalSubTotal + totalVATAmount).ToString();
        }


        private void LoadDataGridView()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows[i].Cells["UnitPrice"].Value = 0;
                dataGridView1.Rows[i].Cells["SubTotal"].Value = 0;
                dataGridView1.Rows[i].Cells["Quantity"].Value = 0;
                dataGridView1.Rows[i].Cells["VATPerc"].Value = 0;
            }
        }

        
        private void btnXML_Click(object sender, EventArgs e)
        {
            XmlDocument invoiceXml = CreateInvoiceXml();
            SaveInvoiceToFile(invoiceXml);
        }

        public static XmlDocument CreateInvoiceXml()
        {
            // Create a new XML document
            XmlDocument xmlDoc = new XmlDocument();

            // Create the root element with namespaces
            XmlElement invoiceElement = xmlDoc.CreateElement("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
            xmlDoc.AppendChild(invoiceElement);

            // Add UBL extensions
            XmlElement ublExtensions = xmlDoc.CreateElement("ext:UBLExtensions", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            XmlElement ublExtension = xmlDoc.CreateElement("ext:UBLExtension", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            XmlElement extensionURI = xmlDoc.CreateElement("ext:ExtensionURI", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            extensionURI.InnerText = "urn:oasis:names:specification:ubl:dsig:enveloped:xades";

            XmlElement extensionContent = xmlDoc.CreateElement("ext:ExtensionContent", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            XmlElement signatureInfo = xmlDoc.CreateElement("sig:UBLDocumentSignatures", "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2");
            signatureInfo.SetAttribute("xmlns:sig", "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2");
            signatureInfo.SetAttribute("xmlns:sac", "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2");
            signatureInfo.SetAttribute("xmlns:sbc", "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2");

            XmlElement sacSignatureInformation = xmlDoc.CreateElement("sac:SignatureInformation", "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2");
            XmlElement cbcID = xmlDoc.CreateElement("cbc:ID", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            cbcID.InnerText = "urn:oasis:names:specification:ubl:signature:1";

            XmlElement sbcReferencedSignatureID = xmlDoc.CreateElement("sbc:ReferencedSignatureID", "urn:oasis:names:specification:ubl:schema/xsd:SignatureBasicComponents-2");
            sbcReferencedSignatureID.InnerText = "urn:oasis:names:specification:ubl:signature:Invoice";

            XmlElement dsSignature = xmlDoc.CreateElement("ds:Signature", "http://www.w3.org/2000/09/xmldsig#");
            dsSignature.SetAttribute("Id", "signature");

            // Add SignedInfo
            XmlElement dsSignedInfo = xmlDoc.CreateElement("ds:SignedInfo", "http://www.w3.org/2000/09/xmldsig#");
            dsSignature.AppendChild(dsSignedInfo);

            // Add CanonicalizationMethod
            XmlElement dsCanonicalizationMethod = xmlDoc.CreateElement("ds:CanonicalizationMethod", "http://www.w3.org/2000/09/xmldsig#");
            dsCanonicalizationMethod.SetAttribute("Algorithm", "http://www.w3.org/2006/12/xml-c14n11");
            dsSignedInfo.AppendChild(dsCanonicalizationMethod);

            // Add SignatureMethod
            XmlElement dsSignatureMethod = xmlDoc.CreateElement("ds:SignatureMethod", "http://www.w3.org/2000/09/xmldsig#");
            dsSignatureMethod.SetAttribute("Algorithm", "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256");
            dsSignedInfo.AppendChild(dsSignatureMethod);

            // Add Reference
            XmlElement dsReference = xmlDoc.CreateElement("ds:Reference", "http://www.w3.org/2000/09/xmldsig#");
            dsReference.SetAttribute("Id", "invoiceSignedData");
            dsReference.SetAttribute("URI", "");
            dsSignedInfo.AppendChild(dsReference);

            // Add Transforms
            XmlElement dsTransforms = xmlDoc.CreateElement("ds:Transforms", "http://www.w3.org/2000/09/xmldsig#");
            dsReference.AppendChild(dsTransforms);

            // Add individual Transform elements
            dsTransforms.AppendChild(CreateTransformElement(xmlDoc, "not(//ancestor-or-self::ext:UBLExtensions)"));
            dsTransforms.AppendChild(CreateTransformElement(xmlDoc, "not(//ancestor-or-self::cac:Signature)"));
            dsTransforms.AppendChild(CreateTransformElement(xmlDoc, "not(//ancestor-or-self::cac:AdditionalDocumentReference[cbc:ID='QR'])"));
            dsTransforms.AppendChild(CreateTransformElement(xmlDoc, ""));

            // Add DigestMethod and DigestValue
            XmlElement dsDigestMethod = xmlDoc.CreateElement("ds:DigestMethod", "http://www.w3.org/2000/09/xmldsig#");
            dsDigestMethod.SetAttribute("Algorithm", "http://www.w3.org/2001/04/xmlenc#sha256");
            dsReference.AppendChild(dsDigestMethod);

            XmlElement dsDigestValue = xmlDoc.CreateElement("ds:DigestValue", "http://www.w3.org/2000/09/xmldsig#");
            dsDigestValue.InnerText = "Hss2gNFjBY5OJn/5CEVZSSNUMrSf4QlCMxwsioPN6fA=";
            dsReference.AppendChild(dsDigestValue);

            // Add another Reference for SignatureProperties
            XmlElement dsReferenceSignatureProperties = xmlDoc.CreateElement("ds:Reference", "http://www.w3.org/2000/09/xmldsig#");
            dsReferenceSignatureProperties.SetAttribute("Type", "http://www.w3.org/2000/09/xmldsig#SignatureProperties");
            dsReferenceSignatureProperties.SetAttribute("URI", "#xadesSignedProperties");
            dsSignedInfo.AppendChild(dsReferenceSignatureProperties);

            // Add DigestMethod and DigestValue for SignatureProperties
            XmlElement dsDigestMethodSignatureProperties = xmlDoc.CreateElement("ds:DigestMethod", "http://www.w3.org/2000/09/xmldsig#");
            dsDigestMethodSignatureProperties.SetAttribute("Algorithm", "http://www.w3.org/2001/04/xmlenc#sha256");
            dsReferenceSignatureProperties.AppendChild(dsDigestMethodSignatureProperties);

            XmlElement dsDigestValueSignatureProperties = xmlDoc.CreateElement("ds:DigestValue", "http://www.w3.org/2000/09/xmldsig#");
            dsDigestValueSignatureProperties.InnerText = "NTUzMzVmMjExNWRjYzZkYzRlNjI1Y2Q1NDM1NWMwYjMzZjQ4MTZiYjlhOTZlMmY5ZDkzM2Q3ZDM1ODliNjE0ZA==";
            dsReferenceSignatureProperties.AppendChild(dsDigestValueSignatureProperties);

            // Add SignatureValue
            XmlElement dsSignatureValue = xmlDoc.CreateElement("ds:SignatureValue", "http://www.w3.org/2000/09/xmldsig#");
            dsSignatureValue.InnerText = "MEUCIQCs+DNQ1vlz7JoovA7JRjakn4tUs0JlCcAoJNh/J65FHwIgKppt2+DfcLXtKQ6yR49tcVydgs/MSY2yV9vATzcpUq4=";
            dsSignature.AppendChild(dsSignatureValue);

            // Add KeyInfo
            XmlElement dsKeyInfo = xmlDoc.CreateElement("ds:KeyInfo", "http://www.w3.org/2000/09/xmldsig#");
            dsSignature.AppendChild(dsKeyInfo);

            XmlElement dsX509Data = xmlDoc.CreateElement("ds:X509Data", "http://www.w3.org/2000/09/xmldsig#");
            dsKeyInfo.AppendChild(dsX509Data);

            XmlElement dsX509Certificate = xmlDoc.CreateElement("ds:X509Certificate", "http://www.w3.org/2000/09/xmldsig#");
            dsX509Certificate.InnerText = "MIID3jCCA4SgAwIBAgITEQAAOAPF90Ajs/xcXwABAAA4AzAKBggqhkjOPQQDAjBiMRUwEwYKCZImiZPyLGQBGRYFbG9jYWwxEzARBgoJkiaJk/IsZAEZFgNnb3YxFzAVBgoJkiaJk/IsZAEZFgdleHRnYXp0MRswGQYDVQQDExJQUlpFSU5WT0lDRVNDQTQtQ0EwHhcNMjQwMTExMDkxOTMwWhcNMjkwMTA5MDkxOTMwWjB1MQswCQYDVQQGEwJTQTEmMCQGA1UEChMdTWF4aW11bSBTcGVlZCBUZWNoIFN1cHBseSBMVEQxFjAUBgNVBAsTDVJpeWFkaCBCcmFuY2gxJjAkBgNVBAMTHVRTVC04ODY0MzExNDUtMzk5OTk5OTk5OTAwMDAzMFYwEAYHKoZIzj0CAQYFK4EEAAoDQgAEoWCKa0Sa9FIErTOv0uAkC1VIKXxU9nPpx2vlf4yhMejy8c02XJblDq7tPydo8mq0ahOMmNo8gwni7Xt1KT9UeKOCAgcwggIDMIGtBgNVHREEgaUwgaKkgZ8wgZwxOzA5BgNVBAQMMjEtVFNUfDItVFNUfDMtZWQyMmYxZDgtZTZhMi0xMTE4LTliNTgtZDlhOGYxMWU0NDVmMR8wHQYKCZImiZPyLGQBAQwPMzk5OTk5OTk5OTAwMDAzMQ0wCwYDVQQMDAQxMTAwMREwDwYDVQQaDAhSUlJEMjkyOTEaMBgGA1UEDwwRU3VwcGx5IGFjdGl2aXRpZXMwHQYDVR0OBBYEFEX+YvmmtnYoDf9BGbKo7ocTKYK1MB8GA1UdIwQYMBaAFJvKqqLtmqwskIFzVvpP2PxT+9NnMHsGCCsGAQUFBwEBBG8wbTBrBggrBgEFBQcwAoZfaHR0cDovL2FpYTQuemF0Y2EuZ292LnNhL0NlcnRFbnJvbGwvUFJaRUludm9pY2VTQ0E0LmV4dGdhenQuZ292LmxvY2FsX1BSWkVJTlZPSUNFU0NBNC1DQSgxKS5jcnQwDgYDVR0PAQH/BAQDAgeAMDwGCSsGAQQBgjcVBwQvMC0GJSsGAQQBgjcVCIGGqB2E0PsShu2dJIfO+xnTwFVmh/qlZYXZhD4CAWQCARIwHQYDVR0lBBYwFAYIKwYBBQUHAwMGCCsGAQUFBwMCMCcGCSsGAQQBgjcVCgQaMBgwCgYIKwYBBQUHAwMwCgYIKwYBBQUHAwIwCgYIKoZIzj0EAwIDSAAwRQIhALE/ichmnWXCUKUbca3yci8oqwaLvFdHVjQrveI9uqAbAiA9hC4M8jgMBADPSzmd2uiPJA6gKR3LE03U75eqbC/rXA==";
            dsX509Data.AppendChild(dsX509Certificate);

            // Append all parts together
            invoiceElement.AppendChild(ublExtensions);
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:ProfileID", "reporting:1.0"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:ID", "SME00010"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:UUID", "8e6000cf-1a98-4174-b3e7-b5d5954bc10d"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:IssueDate", "2022-08-17"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:IssueTime", "17:41:08"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:InvoiceTypeCode", "388", "0200000"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:Note", "ABC", "ar"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:DocumentCurrencyCode", "SAR"));
            invoiceElement.AppendChild(CreateElementWithText(xmlDoc, "cbc:TaxCurrencyCode", "SAR"));

            // Add AdditionalDocumentReferences
            invoiceElement.AppendChild(CreateAdditionalDocumentReference(xmlDoc, "ICV", "10"));
            invoiceElement.AppendChild(CreateAdditionalDocumentReferenceWithAttachment(xmlDoc, "PIH", "NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ==", "text/plain"));
            invoiceElement.AppendChild(CreateAdditionalDocumentReferenceWithAttachment(xmlDoc, "QR", "AW/YtNix2YPYqSDYqtmI2LHZitivINin2YTYqtmD2YbZiNmE2YjYrNmK2Kcg2KjYo9mC2LXZiSDYs9ix2LnYqSDYp9mE2YXYrdiv2YjYr9ipIHwgTWF4aW11bSBTcGVlZCBUZWNoIFN1cHBseSBMVEQCDzM5OTk5OTk5OTkwMDAwMwMTMjAyMi0wOC0xN1QxNzo0MTowOAQGMjMxLjE1BQUzMC4xNQYsSHNzMmdORmpCWTVPSm4vNUNFVlpTU05VTXJTZjRRbENNeHdzaW9QTjZmQT0HYE1FVUNJUUNzK0ROUTF2bHo3Sm9vdkE3SlJqYWtuNHRVczBKbENjQW9KTmgvSjY1Rkh3SWdLcHB0MitEZmNMWHRLUTZ5UjQ5dGNWeWRncy9NU1kyeVY5dkFUemNwVXE0PQhYMFYwEAYHKoZIzj0CAQYFK4EEAAoDQgAEoWCKa0Sa9FIErTOv0uAkC1VIKXxU9nPpx2vlf4yhMejy8c02XJblDq7tPydo8mq0ahOMmNo8gwni7Xt1KT9UeAlHMEUCIQCxP4nIZp1lwlClG3Gt8nIvKKsGi7xXR1Y0K73iPbqgGwIgPYQuDPI4DAQAz0s5ndrojyQOoCkdyxNN1O+Xqmwv61w=", "text/plain"));

            // Add Accounting Supplier Party
            invoiceElement.AppendChild(CreateAccountingSupplierParty(xmlDoc));

            // Add Accounting Customer Party
            invoiceElement.AppendChild(CreateAccountingCustomerParty(xmlDoc));

            // Add Payment Means
            invoiceElement.AppendChild(CreatePaymentMeans(xmlDoc));

            // Add Allowance Charges
            invoiceElement.AppendChild(CreateAllowanceCharge(xmlDoc));

            // Add Tax Total
            invoiceElement.AppendChild(CreateTaxTotal(xmlDoc));

            // Add Legal Monetary Total
            invoiceElement.AppendChild(CreateLegalMonetaryTotal(xmlDoc));

            // Add Invoice Lines
            invoiceElement.AppendChild(CreateInvoiceLine(xmlDoc, "1", 33.000000M, 99.00M, 14.85M, "كتاب", 34.00M));
            invoiceElement.AppendChild(CreateInvoiceLine(xmlDoc, "2", 3.000000M, 102.00M, 15.30M, "قلم", 34.00M));

            return xmlDoc;
        }

        private static XmlElement CreateElementWithText(XmlDocument doc, string elementName, string text, string languageID = null)
        {
            XmlElement element = doc.CreateElement(elementName, "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            element.InnerText = text;
            if (languageID != null)
                element.SetAttribute("languageID", languageID);
            return element;
        }

        private static XmlElement CreateAdditionalDocumentReference(XmlDocument doc, string id, string uuid)
        {
            XmlElement additionalDocRef = doc.CreateElement("cac:AdditionalDocumentReference", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            additionalDocRef.AppendChild(CreateElementWithText(doc, "cbc:ID", id));
            additionalDocRef.AppendChild(CreateElementWithText(doc, "cbc:UUID", uuid));
            return additionalDocRef;
        }

        private static XmlElement CreateAdditionalDocumentReferenceWithAttachment(XmlDocument doc, string id, string embeddedDocument, string mimeCode)
        {
            XmlElement additionalDocRef = doc.CreateElement("cac:AdditionalDocumentReference", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            additionalDocRef.AppendChild(CreateElementWithText(doc, "cbc:ID", id));
            XmlElement attachment = doc.CreateElement("cac:Attachment", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            XmlElement embeddedDoc = doc.CreateElement("cbc:EmbeddedDocumentBinaryObject", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            embeddedDoc.SetAttribute("mimeCode", mimeCode);
            embeddedDoc.InnerText = embeddedDocument;
            attachment.AppendChild(embeddedDoc);
            additionalDocRef.AppendChild(attachment);
            return additionalDocRef;
        }

        private static XmlElement CreateAccountingSupplierParty(XmlDocument doc)
        {
            XmlElement supplierParty = doc.CreateElement("cac:AccountingSupplierParty", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            XmlElement party = doc.CreateElement("cac:Party", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");

            party.AppendChild(CreatePartyIdentification(doc, "1010010000", "CRN"));
            party.AppendChild(CreatePostalAddress(doc, "الامير سلطان | Prince Sultan", "2322", "المربع | Al-Murabba", "الرياض | Riyadh", "23333"));
            party.AppendChild(CreatePartyTaxScheme(doc, "399999999900003", "VAT"));
            party.AppendChild(CreatePartyLegalEntity(doc, "شركة توريد التكنولوجيا بأقصى سرعة المحدودة | Maximum Speed Tech Supply LTD"));

            supplierParty.AppendChild(party);
            return supplierParty;
        }

        private static XmlElement CreateAccountingCustomerParty(XmlDocument doc)
        {
            XmlElement customerParty = doc.CreateElement("cac:AccountingCustomerParty", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            XmlElement party = doc.CreateElement("cac:Party", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");

            party.AppendChild(CreatePostalAddress(doc, "صلاح الدين | Salah Al-Din", "1111", "المروج | Al-Murooj", "الرياض | Riyadh", "12222"));
            party.AppendChild(CreatePartyTaxScheme(doc, "399999999800003", "VAT"));
            party.AppendChild(CreatePartyLegalEntity(doc, "شركة نماذج فاتورة المحدودة | Fatoora Samples LTD"));

            customerParty.AppendChild(party);
            return customerParty;
        }

        private static XmlElement CreatePaymentMeans(XmlDocument doc)
        {
            XmlElement paymentMeans = doc.CreateElement("cac:PaymentMeans", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            paymentMeans.AppendChild(CreateElementWithText(doc, "cbc:PaymentMeansCode", "10"));
            return paymentMeans;
        }

        private static XmlElement CreateAllowanceCharge(XmlDocument doc)
        {
            XmlElement allowanceCharge = doc.CreateElement("cac:AllowanceCharge", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            allowanceCharge.AppendChild(CreateElementWithText(doc, "cbc:ChargeIndicator", "false"));
            allowanceCharge.AppendChild(CreateElementWithText(doc, "cbc:AllowanceChargeReason", "discount"));
            allowanceCharge.AppendChild(CreateElementWithText(doc, "cbc:Amount", "0.00", "SAR"));

            XmlElement taxCategory = doc.CreateElement("cac:TaxCategory", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            taxCategory.AppendChild(CreateElementWithText(doc, "cbc:ID", "S", "UN/ECE 5305"));
            taxCategory.AppendChild(CreateElementWithText(doc, "cbc:Percent", "15"));

            XmlElement taxScheme = doc.CreateElement("cac:TaxScheme", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            taxScheme.AppendChild(CreateElementWithText(doc, "cbc:ID", "VAT", "UN/ECE 5153"));

            taxCategory.AppendChild(taxScheme);
            allowanceCharge.AppendChild(taxCategory);
            return allowanceCharge;
        }

        private static XmlElement CreateTaxTotal(XmlDocument doc)
        {
            XmlElement taxTotal = doc.CreateElement("cac:TaxTotal", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            taxTotal.AppendChild(CreateElementWithText(doc, "cbc:TaxAmount", "30.15", "SAR"));
            return taxTotal;
        }

        private static XmlElement CreateLegalMonetaryTotal(XmlDocument doc)
        {
            XmlElement legalMonetaryTotal = doc.CreateElement("cac:LegalMonetaryTotal", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:LineExtensionAmount", "201.00", "SAR"));
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:TaxExclusiveAmount", "201.00", "SAR"));
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:TaxInclusiveAmount", "231.15", "SAR"));
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:AllowanceTotalAmount", "0.00", "SAR"));
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:PrepaidAmount", "0.00", "SAR"));
            legalMonetaryTotal.AppendChild(CreateElementWithText(doc, "cbc:PayableAmount", "231.15", "SAR"));
            return legalMonetaryTotal;
        }

        private static XmlElement CreateInvoiceLine(XmlDocument doc, string id, decimal quantity, decimal lineAmount, decimal taxAmount, string itemName, decimal priceAmount)
        {
            XmlElement invoiceLine = doc.CreateElement("cac:InvoiceLine", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");

            invoiceLine.AppendChild(CreateElementWithText(doc, "cbc:ID", id));
            invoiceLine.AppendChild(CreateElementWithText(doc, "cbc:InvoicedQuantity", quantity.ToString(), "PCE"));
            invoiceLine.AppendChild(CreateElementWithText(doc, "cbc:LineExtensionAmount", lineAmount.ToString(), "SAR"));

            // Add Tax Total
            XmlElement taxTotal = doc.CreateElement("cac:TaxTotal", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            taxTotal.AppendChild(CreateElementWithText(doc, "cbc:TaxAmount", taxAmount.ToString(), "SAR"));
            invoiceLine.AppendChild(taxTotal);

            // Add Item
            XmlElement item = doc.CreateElement("cac:Item", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            item.AppendChild(CreateElementWithText(doc, "cbc:Name", itemName));
            invoiceLine.AppendChild(item);

            // Add Price
            XmlElement price = doc.CreateElement("cac:Price", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            price.AppendChild(CreateElementWithText(doc, "cbc:PriceAmount", priceAmount.ToString(), "SAR"));
            invoiceLine.AppendChild(price);

            return invoiceLine;
        }

        private static XmlElement CreatePartyIdentification(XmlDocument doc, string id, string schemeID)
        {
            XmlElement partyIdentification = doc.CreateElement("cac:PartyIdentification", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            XmlElement idElement = doc.CreateElement("cbc:ID", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            idElement.SetAttribute("schemeID", schemeID);
            idElement.InnerText = id;
            partyIdentification.AppendChild(idElement);
            return partyIdentification;
        }

        private static XmlElement CreatePostalAddress(XmlDocument doc, string streetName, string buildingNumber, string citySubdivisionName, string cityName, string postalZone)
        {
            XmlElement postalAddress = doc.CreateElement("cac:PostalAddress", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            postalAddress.AppendChild(CreateElementWithText(doc, "cbc:StreetName", streetName));
            postalAddress.AppendChild(CreateElementWithText(doc, "cbc:BuildingNumber", buildingNumber));
            postalAddress.AppendChild(CreateElementWithText(doc, "cbc:CitySubdivisionName", citySubdivisionName));
            postalAddress.AppendChild(CreateElementWithText(doc, "cbc:CityName", cityName));
            postalAddress.AppendChild(CreateElementWithText(doc, "cbc:PostalZone", postalZone));
            postalAddress.AppendChild(CreateElementWithText(doc, "cac:Country", "SA"));
            return postalAddress;
        }

        private static XmlElement CreatePartyTaxScheme(XmlDocument doc, string companyId, string taxSchemeId)
        {
            XmlElement partyTaxScheme = doc.CreateElement("cac:PartyTaxScheme", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            partyTaxScheme.AppendChild(CreateElementWithText(doc, "cbc:CompanyID", companyId));
            XmlElement taxScheme = doc.CreateElement("cac:TaxScheme", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            taxScheme.AppendChild(CreateElementWithText(doc, "cbc:ID", taxSchemeId));
            partyTaxScheme.AppendChild(taxScheme);
            return partyTaxScheme;
        }

        private static XmlElement CreatePartyLegalEntity(XmlDocument doc, string registrationName)
        {
            XmlElement partyLegalEntity = doc.CreateElement("cac:PartyLegalEntity", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            partyLegalEntity.AppendChild(CreateElementWithText(doc, "cbc:RegistrationName", registrationName));
            return partyLegalEntity;
        }

        private static XmlElement CreateTransformElement(XmlDocument doc, string xpath)
        {
            XmlElement transform = doc.CreateElement("ds:Transform", "http://www.w3.org/2000/09/xmldsig#");
            transform.SetAttribute("Algorithm", "http://www.w3.org/TR/1999/REC-xpath-19991116");
            XmlElement xpathElement = doc.CreateElement("ds:XPath", "http://www.w3.org/2000/09/xmldsig#");
            xpathElement.InnerText = xpath;
            transform.AppendChild(xpathElement);
            return transform;
        }

        private void SaveInvoiceToFile(XmlDocument invoiceXml)
        {
            string filePath = $@"G:\Faizan\AllProjects\Zatca\ZatcaSavedXMLFiles\Invoice_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xml";

            try
            {
                invoiceXml.Save(filePath);
                MessageBox.Show("Invoice saved successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message);
            }
        }

    }
}
