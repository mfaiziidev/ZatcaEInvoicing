
namespace ZatcaEInvoicing
{
    partial class FrmReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporting));
            this.btn_Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InvoiceHash = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_reportingStatus = new System.Windows.Forms.TextBox();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.btn_ComplianceInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(107, 411);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(114, 42);
            this.btn_Back.TabIndex = 73;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Invoice";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Location = new System.Drawing.Point(10, 228);
            this.txt_Invoice.Multiline = true;
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(464, 20);
            this.txt_Invoice.TabIndex = 71;
            this.txt_Invoice.Text = resources.GetString("txt_Invoice.Text");
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(360, 411);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(114, 42);
            this.btn_Next.TabIndex = 70;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Reporting Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "UUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Invoice Hash";
            // 
            // txt_InvoiceHash
            // 
            this.txt_InvoiceHash.Location = new System.Drawing.Point(13, 168);
            this.txt_InvoiceHash.Multiline = true;
            this.txt_InvoiceHash.Name = "txt_InvoiceHash";
            this.txt_InvoiceHash.Size = new System.Drawing.Size(205, 26);
            this.txt_InvoiceHash.TabIndex = 65;
            this.txt_InvoiceHash.Text = "Hss2gNFjBY5OJn/5CEVZSSNUMrSf4QlCMxwsioPN6fA=";
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Status.Location = new System.Drawing.Point(13, 310);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(205, 55);
            this.txt_Status.TabIndex = 64;
            // 
            // txt_reportingStatus
            // 
            this.txt_reportingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reportingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_reportingStatus.Location = new System.Drawing.Point(230, 310);
            this.txt_reportingStatus.Multiline = true;
            this.txt_reportingStatus.Name = "txt_reportingStatus";
            this.txt_reportingStatus.ReadOnly = true;
            this.txt_reportingStatus.Size = new System.Drawing.Size(244, 55);
            this.txt_reportingStatus.TabIndex = 63;
            // 
            // txt_UUID
            // 
            this.txt_UUID.Location = new System.Drawing.Point(227, 168);
            this.txt_UUID.Multiline = true;
            this.txt_UUID.Name = "txt_UUID";
            this.txt_UUID.Size = new System.Drawing.Size(247, 26);
            this.txt_UUID.TabIndex = 62;
            this.txt_UUID.Text = "8e6000cf-1a98-4174-b3e7-b5d5954bc10d";
            // 
            // btn_ComplianceInvoice
            // 
            this.btn_ComplianceInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ComplianceInvoice.Location = new System.Drawing.Point(227, 411);
            this.btn_ComplianceInvoice.Name = "btn_ComplianceInvoice";
            this.btn_ComplianceInvoice.Size = new System.Drawing.Size(130, 42);
            this.btn_ComplianceInvoice.TabIndex = 61;
            this.btn_ComplianceInvoice.Text = "Submit Report";
            this.btn_ComplianceInvoice.UseVisualStyleBackColor = true;
            this.btn_ComplianceInvoice.Click += new System.EventHandler(this.btn_ComplianceInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 60;
            this.label1.Text = "Reporting";
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 512);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_InvoiceHash);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_reportingStatus);
            this.Controls.Add(this.txt_UUID);
            this.Controls.Add(this.btn_ComplianceInvoice);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporting";
            this.Text = "Reporting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_InvoiceHash;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_reportingStatus;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.Button btn_ComplianceInvoice;
        private System.Windows.Forms.Label label1;
    }
}