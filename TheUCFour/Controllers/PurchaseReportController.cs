using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheUCFour.BLL.BLL;
using TheUCFour.ViewModel.ViewModel;

namespace TheUCFour.Controllers
{
    public class PurchaseReportController : Controller
    {
        PurchaseReportManager _purchaseReportManager = new PurchaseReportManager();
        // GET: Report
        public ActionResult PurchaseReport()
        {
            PurchaseView1 purchaseView1 = new PurchaseView1();
            purchaseView1.PurchaseView1s = _purchaseReportManager.LoadProducts();
            return View(purchaseView1);
        }
    }
}