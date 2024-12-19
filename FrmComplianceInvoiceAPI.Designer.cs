
namespace ZatcaEInvoicing
{
    partial class FrmComplianceInvoiceAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComplianceInvoiceAPI));
            this.btn_Next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InvoiceHash = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_ClearanceStatus = new System.Windows.Forms.TextBox();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.btn_ComplianceInvoice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(359, 426);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(114, 42);
            this.btn_Next.TabIndex = 28;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Clearance Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "UUID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Invoice Hash";
            // 
            // txt_InvoiceHash
            // 
            this.txt_InvoiceHash.Location = new System.Drawing.Point(12, 183);
            this.txt_InvoiceHash.Multiline = true;
            this.txt_InvoiceHash.Name = "txt_InvoiceHash";
            this.txt_InvoiceHash.Size = new System.Drawing.Size(205, 26);
            this.txt_InvoiceHash.TabIndex = 23;
            this.txt_InvoiceHash.Text = "f+0WCqnPkInI+eL9G3LAry12fTPf+toC9UX07F4fI+s=";
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Status.Location = new System.Drawing.Point(12, 325);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(205, 55);
            this.txt_Status.TabIndex = 22;
            // 
            // txt_ClearanceStatus
            // 
            this.txt_ClearanceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClearanceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_ClearanceStatus.Location = new System.Drawing.Point(229, 325);
            this.txt_ClearanceStatus.Multiline = true;
            this.txt_ClearanceStatus.Name = "txt_ClearanceStatus";
            this.txt_ClearanceStatus.ReadOnly = true;
            this.txt_ClearanceStatus.Size = new System.Drawing.Size(244, 55);
            this.txt_ClearanceStatus.TabIndex = 21;
            // 
            // txt_UUID
            // 
            this.txt_UUID.Location = new System.Drawing.Point(226, 183);
            this.txt_UUID.Multiline = true;
            this.txt_UUID.Name = "txt_UUID";
            this.txt_UUID.Size = new System.Drawing.Size(247, 26);
            this.txt_UUID.TabIndex = 20;
            this.txt_UUID.Text = "8d487816-70b8-4ade-a618-9d620b73814a";
            // 
            // btn_ComplianceInvoice
            // 
            this.btn_ComplianceInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ComplianceInvoice.Location = new System.Drawing.Point(226, 426);
            this.btn_ComplianceInvoice.Name = "btn_ComplianceInvoice";
            this.btn_ComplianceInvoice.Size = new System.Drawing.Size(130, 42);
            this.btn_ComplianceInvoice.TabIndex = 19;
            this.btn_ComplianceInvoice.Text = "Compliance Invoice";
            this.btn_ComplianceInvoice.UseVisualStyleBackColor = true;
            this.btn_ComplianceInvoice.Click += new System.EventHandler(this.btn_ComplianceInvoice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Invoice";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Location = new System.Drawing.Point(9, 243);
            this.txt_Invoice.Multiline = true;
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(464, 26);
            this.txt_Invoice.TabIndex = 29;
            this.txt_Invoice.Text = resources.GetString("txt_Invoice.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Compliance Invoices";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(106, 426);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(114, 42);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // FrmComplianceInvoiceAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 508);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_InvoiceHash);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_ClearanceStatus);
            this.Controls.Add(this.txt_UUID);
            this.Controls.Add(this.btn_ComplianceInvoice);
            this.Name = "FrmComplianceInvoiceAPI";
            this.Text = "FrmComplianceInvoiceAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InvoiceHash;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_ClearanceStatus;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.Button btn_ComplianceInvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Back;
    }
}