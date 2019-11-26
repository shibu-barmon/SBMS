using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheUCFour.ViewModel.ViewModel;
using TheUCFour.Repository.Repository;

namespace TheUCFour.BLL.BLL
{
    public class PurchaseReportManager
    {
        PurchaseReportRepository _purchaseReportRepository = new PurchaseReportRepository();
        public List<PurchaseView1> LoadProducts()
        {
            return _purchaseReportRepository.LoadProducts();
        }
    }
}
