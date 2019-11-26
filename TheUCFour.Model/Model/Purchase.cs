﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUCFour.Model.Model
{
    public class Purchase
    {
        public Purchase()
        {
            PurchaseDetails = new List<PurchaseDetails>();
        }

        public int Id { get; set; }
        public string Date { get; set; }
        public string InvoiceNo { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<PurchaseDetails> PurchaseDetails { get; set; }
    }
}
