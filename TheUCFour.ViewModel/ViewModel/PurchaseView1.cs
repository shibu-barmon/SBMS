using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUCFour.ViewModel.ViewModel
{
    public class PurchaseView1
    {
        public string Product { get; set; }
        public string Date { get; set; }
        public double AvailableQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }
        public List<PurchaseView1> PurchaseView1s { get; set; }
    }
}
