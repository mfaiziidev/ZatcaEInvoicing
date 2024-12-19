
namespace ZatcaEInvoicing
{
    partial class FrmEnterInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbInvoiceType = new System.Windows.Forms.ComboBox();
            this.txtBusinessType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSellerCompanyName = new System.Windows.Forms.TextBox();
            this.txtSellerCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtSellerVatID = new System.Windows.Forms.TextBox();
            this.txtInvoiceRefNo = new System.Windows.Forms.TextBox();
            this.txtBuyerCompanyName = new System.Windows.Forms.TextBox();
            this.txtBuyerCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtBuyerVatID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSubTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVatAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Reference No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date/Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seller Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compay Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Company Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "VAT ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Buyer Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Company Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Company Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "VAT ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Business Type";
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.FormattingEnabled = true;
            this.cmbInvoiceType.Items.AddRange(new object[] {
            "Sale Invoice",
            "Tax Invoice"});
            this.cmbInvoiceType.Location = new System.Drawing.Point(97, 75);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Size = new System.Drawing.Size(196, 21);
            this.cmbInvoiceType.TabIndex = 12;
            // 
            // txtBusinessType
            // 
            this.txtBusinessType.FormattingEnabled = true;
            this.txtBusinessType.Items.AddRange(new object[] {
            "B2B",
            "B2C"});
            this.txtBusinessType.Location = new System.Drawing.Point(583, 92);
            this.txtBusinessType.Name = "txtBusinessType";
            this.txtBusinessType.Size = new System.Drawing.Size(196, 21);
            this.txtBusinessType.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(266, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 31);
            this.label13.TabIndex = 14;
            this.label13.Text = "Zatca E-Invoicing";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "_________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(548, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "______________________________________";
            // 
            // txtSellerCompanyName
            // 
            this.txtSellerCompanyName.Location = new System.Drawing.Point(97, 176);
            this.txtSellerCompanyName.Name = "txtSellerCompanyName";
            this.txtSellerCompanyName.Size = new System.Drawing.Size(196, 20);
            this.txtSellerCompanyName.TabIndex = 18;
            // 
            // txtSellerCompanyAddress
            // 
            this.txtSellerCompanyAddress.Location = new System.Drawing.Point(97, 197);
            this.txtSellerCompanyAddress.Name = "txtSellerCompanyAddress";
            this.txtSellerCompanyAddress.Size = new System.Drawing.Size(196, 20);
            this.txtSellerCompanyAddress.TabIndex = 19;
            // 
            // txtSellerVatID
            // 
            this.txtSellerVatID.Location = new System.Drawing.Point(97, 218);
            this.txtSellerVatID.Name = "txtSellerVatID";
            this.txtSellerVatID.Size = new System.Drawing.Size(196, 20);
            this.txtSellerVatID.TabIndex = 20;
            // 
            // txtInvoiceRefNo
            // 
            this.txtInvoiceRefNo.Location = new System.Drawing.Point(583, 71);
            this.txtInvoiceRefNo.Name = "txtInvoiceRefNo";
            this.txtInvoiceRefNo.Size = new System.Drawing.Size(196, 20);
            this.txtInvoiceRefNo.TabIndex = 21;
            // 
            // txtBuyerCompanyName
            // 
            this.txtBuyerCompanyName.Location = new System.Drawing.Point(583, 173);
            this.txtBuyerCompanyName.Name = "txtBuyerCompanyName";
            this.txtBuyerCompanyName.Size = new System.Drawing.Size(196, 20);
            this.txtBuyerCompanyName.TabIndex = 22;
            // 
            // txtBuyerCompanyAddress
            // 
            this.txtBuyerCompanyAddress.Location = new System.Drawing.Point(583, 194);
            this.txtBuyerCompanyAddress.Name = "txtBuyerCompanyAddress";
            this.txtBuyerCompanyAddress.Size = new System.Drawing.Size(196, 20);
            this.txtBuyerCompanyAddress.TabIndex = 23;
            // 
            // txtBuyerVatID
            // 
            this.txtBuyerVatID.Location = new System.Drawing.Point(583, 215);
            this.txtBuyerVatID.Name = "txtBuyerVatID";
            this.txtBuyerVatID.Size = new System.Drawing.Size(196, 20);
            this.txtBuyerVatID.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(469, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 30);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Convert Into PDF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(682, 259);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(98, 30);
            this.btnXML.TabIndex = 27;
            this.btnXML.Text = "Convert Into XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.UnitPrice,
            this.Quantity,
            this.VatPerc,
            this.VATAmount,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(1, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 174);
            this.dataGridView1.TabIndex = 28;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // VatPerc
            // 
            this.VatPerc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VatPerc.HeaderText = "VAT %";
            this.VatPerc.Name = "VatPerc";
            // 
            // VATAmount
            // 
            this.VATAmount.HeaderText = "VAT Amount";
            this.VATAmount.Name = "VATAmount";
            this.VATAmount.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(97, 97);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.DateTimePicker.TabIndex = 29;
            // 
            // btnSubTotal
            // 
            this.btnSubTotal.Location = new System.Drawing.Point(353, 259);
            this.btnSubTotal.Name = "btnSubTotal";
            this.btnSubTotal.Size = new System.Drawing.Size(116, 30);
            this.btnSubTotal.TabIndex = 30;
            this.btnSubTotal.Text = "SubTotal";
            this.btnSubTotal.UseVisualStyleBackColor = true;
            this.btnSubTotal.Click += new System.EventHandler(this.btnSubTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(631, 468);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(536, 472);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Total";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Location = new System.Drawing.Point(631, 510);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(150, 20);
            this.txtNetTotal.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(536, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Net Total";
            // 
            // txtVatAmount
            // 
            this.txtVatAmount.Location = new System.Drawing.Point(631, 489);
            this.txtVatAmount.Name = "txtVatAmount";
            this.txtVatAmount.ReadOnly = true;
            this.txtVatAmount.Size = new System.Drawing.Size(150, 20);
            this.txtVatAmount.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(536, 493);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Total VAT Amount";
            // 
            // FrmEnterInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 558);
            this.Controls.Add(this.txtVatAmount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNetTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSubTotal);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBuyerVatID);
            this.Controls.Add(this.txtBuyerCompanyAddress);
            this.Controls.Add(this.txtBuyerCompanyName);
            this.Controls.Add(this.txtInvoiceRefNo);
            this.Controls.Add(this.txtSellerVatID);
            this.Controls.Add(this.txtSellerCompanyAddress);
            this.Controls.Add(this.txtSellerCompanyName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBusinessType);
            this.Controls.Add(this.cmbInvoiceType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEnterInvoice";
            this.Text = "EnterInvoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbInvoiceType;
        private System.Windows.Forms.ComboBox txtBusinessType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSellerCompanyName;
        private System.Windows.Forms.TextBox txtSellerCompanyAddress;
        private System.Windows.Forms.TextBox txtSellerVatID;
        private System.Windows.Forms.TextBox txtInvoiceRefNo;
        private System.Windows.Forms.TextBox txtBuyerCompanyName;
        private System.Windows.Forms.TextBox txtBuyerCompanyAddress;
        private System.Windows.Forms.TextBox txtBuyerVatID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button btnSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVatAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}

