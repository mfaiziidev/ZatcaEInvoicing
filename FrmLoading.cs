using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZatcaEInvoicing
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.MaximizeBox = false; 

            lblLoading.Text = "Please wait, processing your request...";
            lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblLoading.Font = new Font(lblLoading.Font, FontStyle.Bold);

           
            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee; 
            progressBar.Dock = DockStyle.Bottom; 
            this.Controls.Add(progressBar);

        }
    }
}