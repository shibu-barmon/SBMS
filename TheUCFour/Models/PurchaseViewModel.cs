using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheUCFour.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace TheUCFour.Models
{
    public class PurchaseViewModel
    {
        public PurchaseViewModel()
        {
            PurchaseDetails = new List<PurchaseDetails>();
        }
        public int Id { get; set; }
        public string Date { get; set; }
        [StringLength(4, MinimumLength = 4, ErrorMessage = "InvoiceNo must 4 digit length..")]
        public string InvoiceNo { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<PurchaseDetails> PurchaseDetails { get; set; }
        public List<SelectListItem> SupplierSelectListItems { get; set; }


        //public int ProductId { get; set; }
        //public Product Product { get; set; }
        //public List<SelectListItem> ProductSelectListItems { get; set; }

        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        //public List<SelectListItem> CategorySelectListItems { get; set; }
    }
}