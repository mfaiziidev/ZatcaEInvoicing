using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZatcaEInvoicing
{
    class DataBank
    {
        public int InvoiceID { get; set; }
        public int UnitPrice { get; set; }
        public int SubTotal { get; set; }
        public int VATPerc { get; set; }
        public string InvoiceRefNo { get; set; }
        public string BusinessType { get; set; }
        public string SellerCompanyName { get; set; }
        public string SellerCompanyAddress { get; set; }
        public string SellerVatID { get; set; }
        public string BuyerComapnyName { get; set; }
        public string BuyerComapnyAddress { get; set; }
        public string BuyerVatID { get; set; }
        public string ItemName { get; set; }
        public DateTime DateTime { get; set;}

    }
}
