
namespace ZatcaEInvoicing
{
    partial class FrmClearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClearance));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InvoiceHash = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_ClearingStatus = new System.Windows.Forms.TextBox();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.btn_ClearInvoice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ClearedInvoice = new System.Windows.Forms.TextBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Clearance";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(257, 503);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(114, 42);
            this.btn_Back.TabIndex = 59;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Invoice";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Location = new System.Drawing.Point(43, 263);
            this.txt_Invoice.Multiline = true;
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(464, 26);
            this.txt_Invoice.TabIndex = 57;
            this.txt_Invoice.Text = resources.GetString("txt_Invoice.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Clearing Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "UUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Invoice Hash";
            // 
            // txt_InvoiceHash
            // 
            this.txt_InvoiceHash.Location = new System.Drawing.Point(46, 203);
            this.txt_InvoiceHash.Multiline = true;
            this.txt_InvoiceHash.Name = "txt_InvoiceHash";
            this.txt_InvoiceHash.Size = new System.Drawing.Size(205, 26);
            this.txt_InvoiceHash.TabIndex = 51;
            this.txt_InvoiceHash.Text = "f+0WCqnPkInI+eL9G3LAry12fTPf+toC9UX07F4fI+s=";
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Status.Location = new System.Drawing.Point(40, 392);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(205, 55);
            this.txt_Status.TabIndex = 50;
            // 
            // txt_ClearingStatus
            // 
            this.txt_ClearingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClearingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_ClearingStatus.Location = new System.Drawing.Point(263, 392);
            this.txt_ClearingStatus.Multiline = true;
            this.txt_ClearingStatus.Name = "txt_ClearingStatus";
            this.txt_ClearingStatus.ReadOnly = true;
            this.txt_ClearingStatus.Size = new System.Drawing.Size(244, 55);
            this.txt_ClearingStatus.TabIndex = 49;
            // 
            // txt_UUID
            // 
            this.txt_UUID.Location = new System.Drawing.Point(260, 203);
            this.txt_UUID.Multiline = true;
            this.txt_UUID.Name = "txt_UUID";
            this.txt_UUID.Size = new System.Drawing.Size(247, 26);
            this.txt_UUID.TabIndex = 48;
            this.txt_UUID.Text = "8d487816-70b8-4ade-a618-9d620b73814a";
            // 
            // btn_ClearInvoice
            // 
            this.btn_ClearInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearInvoice.Location = new System.Drawing.Point(377, 503);
            this.btn_ClearInvoice.Name = "btn_ClearInvoice";
            this.btn_ClearInvoice.Size = new System.Drawing.Size(130, 42);
            this.btn_ClearInvoice.TabIndex = 47;
            this.btn_ClearInvoice.Text = "Clear Invoice";
            this.btn_ClearInvoice.UseVisualStyleBackColor = true;
            this.btn_ClearInvoice.Click += new System.EventHandler(this.btn_ClearInvoice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Cleared Invoice";
            // 
            // txt_ClearedInvoice
            // 
            this.txt_ClearedInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClearedInvoice.ForeColor = System.Drawing.Color.Black;
            this.txt_ClearedInvoice.Location = new System.Drawing.Point(43, 323);
            this.txt_ClearedInvoice.Multiline = true;
            this.txt_ClearedInvoice.Name = "txt_ClearedInvoice";
            this.txt_ClearedInvoice.ReadOnly = true;
            this.txt_ClearedInvoice.Size = new System.Drawing.Size(464, 33);
            this.txt_ClearedInvoice.TabIndex = 60;
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(407, 89);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(100, 82);
            this.pictureBoxQRCode.TabIndex = 62;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // FrmClearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 581);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ClearedInvoice);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_InvoiceHash);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_ClearingStatus);
            this.Controls.Add(this.txt_UUID);
            this.Controls.Add(this.btn_ClearInvoice);
            this.Controls.Add(this.label1);
            this.Name = "FrmClearance";
            this.Text = "Clearance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_InvoiceHash;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_ClearingStatus;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.Button btn_ClearInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ClearedInvoice;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}