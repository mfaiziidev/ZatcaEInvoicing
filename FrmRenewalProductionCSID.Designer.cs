
namespace ZatcaEInvoicing
{
    partial class FrmRenewalProductionCSID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenewalProductionCSID));
            this.btn_Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CSR = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RequestID = new System.Windows.Forms.TextBox();
            this.txt_BinarySecurityToken = new System.Windows.Forms.TextBox();
            this.txt_DipositationMsg = new System.Windows.Forms.TextBox();
            this.txt_Secret = new System.Windows.Forms.TextBox();
            this.btn_ProductionCSID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(86, 390);
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
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "CSR";
            // 
            // txt_CSR
            // 
            this.txt_CSR.Location = new System.Drawing.Point(21, 116);
            this.txt_CSR.Multiline = true;
            this.txt_CSR.Name = "txt_CSR";
            this.txt_CSR.Size = new System.Drawing.Size(464, 26);
            this.txt_CSR.TabIndex = 57;
            this.txt_CSR.Text = resources.GetString("txt_CSR.Text");
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(371, 390);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(114, 42);
            this.btn_Next.TabIndex = 56;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Binary Security Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Disposition Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Secret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Request ID";
            // 
            // txt_RequestID
            // 
            this.txt_RequestID.Location = new System.Drawing.Point(21, 210);
            this.txt_RequestID.Multiline = true;
            this.txt_RequestID.Name = "txt_RequestID";
            this.txt_RequestID.ReadOnly = true;
            this.txt_RequestID.Size = new System.Drawing.Size(205, 26);
            this.txt_RequestID.TabIndex = 51;
            // 
            // txt_BinarySecurityToken
            // 
            this.txt_BinarySecurityToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BinarySecurityToken.ForeColor = System.Drawing.Color.Black;
            this.txt_BinarySecurityToken.Location = new System.Drawing.Point(21, 290);
            this.txt_BinarySecurityToken.Multiline = true;
            this.txt_BinarySecurityToken.Name = "txt_BinarySecurityToken";
            this.txt_BinarySecurityToken.ReadOnly = true;
            this.txt_BinarySecurityToken.Size = new System.Drawing.Size(205, 55);
            this.txt_BinarySecurityToken.TabIndex = 50;
            // 
            // txt_DipositationMsg
            // 
            this.txt_DipositationMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DipositationMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_DipositationMsg.Location = new System.Drawing.Point(238, 290);
            this.txt_DipositationMsg.Multiline = true;
            this.txt_DipositationMsg.Name = "txt_DipositationMsg";
            this.txt_DipositationMsg.ReadOnly = true;
            this.txt_DipositationMsg.Size = new System.Drawing.Size(247, 55);
            this.txt_DipositationMsg.TabIndex = 49;
            // 
            // txt_Secret
            // 
            this.txt_Secret.Location = new System.Drawing.Point(238, 210);
            this.txt_Secret.Multiline = true;
            this.txt_Secret.Name = "txt_Secret";
            this.txt_Secret.ReadOnly = true;
            this.txt_Secret.Size = new System.Drawing.Size(247, 26);
            this.txt_Secret.TabIndex = 48;
            this.txt_Secret.Text = " ";
            // 
            // btn_ProductionCSID
            // 
            this.btn_ProductionCSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductionCSID.Location = new System.Drawing.Point(207, 390);
            this.btn_ProductionCSID.Name = "btn_ProductionCSID";
            this.btn_ProductionCSID.Size = new System.Drawing.Size(156, 42);
            this.btn_ProductionCSID.TabIndex = 47;
            this.btn_ProductionCSID.Text = " Renew Production CSID";
            this.btn_ProductionCSID.UseVisualStyleBackColor = true;
            this.btn_ProductionCSID.Click += new System.EventHandler(this.btn_ProductionCSID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Renewal Production CSID";
            // 
            // FrmRenewalProductionCSID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 491);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CSR);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_RequestID);
            this.Controls.Add(this.txt_BinarySecurityToken);
            this.Controls.Add(this.txt_DipositationMsg);
            this.Controls.Add(this.txt_Secret);
            this.Controls.Add(this.btn_ProductionCSID);
            this.Controls.Add(this.label1);
            this.Name = "FrmRenewalProductionCSID";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CSR;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_RequestID;
        private System.Windows.Forms.TextBox txt_BinarySecurityToken;
        private System.Windows.Forms.TextBox txt_DipositationMsg;
        private System.Windows.Forms.TextBox txt_Secret;
        private System.Windows.Forms.Button btn_ProductionCSID;
        private System.Windows.Forms.Label label1;
    }
}