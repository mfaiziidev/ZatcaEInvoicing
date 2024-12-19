
namespace ZatcaEInvoicing
{
    partial class FrmGenerateCSID
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ReqID = new System.Windows.Forms.TextBox();
            this.txt_SecretKey = new System.Windows.Forms.TextBox();
            this.txt_DopMsg = new System.Windows.Forms.TextBox();
            this.txt_GntCSID = new System.Windows.Forms.TextBox();
            this.btn_GntCSID = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "SecretID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Drop Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CSID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "RequestID";
            // 
            // txt_ReqID
            // 
            this.txt_ReqID.Location = new System.Drawing.Point(18, 171);
            this.txt_ReqID.Multiline = true;
            this.txt_ReqID.Name = "txt_ReqID";
            this.txt_ReqID.ReadOnly = true;
            this.txt_ReqID.Size = new System.Drawing.Size(205, 97);
            this.txt_ReqID.TabIndex = 13;
            // 
            // txt_SecretKey
            // 
            this.txt_SecretKey.Location = new System.Drawing.Point(18, 313);
            this.txt_SecretKey.Multiline = true;
            this.txt_SecretKey.Name = "txt_SecretKey";
            this.txt_SecretKey.ReadOnly = true;
            this.txt_SecretKey.Size = new System.Drawing.Size(205, 55);
            this.txt_SecretKey.TabIndex = 12;
            // 
            // txt_DopMsg
            // 
            this.txt_DopMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DopMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_DopMsg.Location = new System.Drawing.Point(235, 313);
            this.txt_DopMsg.Multiline = true;
            this.txt_DopMsg.Name = "txt_DopMsg";
            this.txt_DopMsg.ReadOnly = true;
            this.txt_DopMsg.Size = new System.Drawing.Size(244, 55);
            this.txt_DopMsg.TabIndex = 11;
            // 
            // txt_GntCSID
            // 
            this.txt_GntCSID.Location = new System.Drawing.Point(232, 171);
            this.txt_GntCSID.Multiline = true;
            this.txt_GntCSID.Name = "txt_GntCSID";
            this.txt_GntCSID.ReadOnly = true;
            this.txt_GntCSID.Size = new System.Drawing.Size(247, 97);
            this.txt_GntCSID.TabIndex = 10;
            // 
            // btn_GntCSID
            // 
            this.btn_GntCSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GntCSID.Location = new System.Drawing.Point(235, 421);
            this.btn_GntCSID.Name = "btn_GntCSID";
            this.btn_GntCSID.Size = new System.Drawing.Size(114, 59);
            this.btn_GntCSID.TabIndex = 9;
            this.btn_GntCSID.Text = "Generate CSID";
            this.btn_GntCSID.UseVisualStyleBackColor = true;
            this.btn_GntCSID.Click += new System.EventHandler(this.btn_GntCSID_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(365, 421);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(114, 59);
            this.btn_Next.TabIndex = 18;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Generate CSID";
            // 
            // FrmGenerateCSID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ReqID);
            this.Controls.Add(this.txt_SecretKey);
            this.Controls.Add(this.txt_DopMsg);
            this.Controls.Add(this.txt_GntCSID);
            this.Controls.Add(this.btn_GntCSID);
            this.Name = "FrmGenerateCSID";
            this.Text = "Generate CSID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ReqID;
        private System.Windows.Forms.TextBox txt_SecretKey;
        private System.Windows.Forms.TextBox txt_DopMsg;
        private System.Windows.Forms.TextBox txt_GntCSID;
        private System.Windows.Forms.Button btn_GntCSID;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label5;
    }
}