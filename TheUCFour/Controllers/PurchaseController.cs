using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheUCFour.Model.Model;
using TheUCFour.Models;
using TheUCFour.BLL.BLL;
using AutoMapper;

namespace TheUCFour.Controllers
{
    public class PurchaseController : Controller
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        SupplierManager _supplierManager = new SupplierManager();
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();

        public ActionResult AddPurchase()
        {
            PurchaseViewModel purchaseViewModel = new PurchaseViewModel();
            PurchaseDetailsViewModel purchaseDetailsViewModel = new PurchaseDetailsViewModel();
            
            purchaseViewModel.SupplierSelectListItems = _supplierManager
                                                        .GetAll()
                                                        .Select(c => new SelectListItem()
                                                        {
                                                            Value = c.Id.ToString(),
                                                            Text = c.Name
                                                        }).ToList();
            //purchaseViewModel.CategorySelectListItems = _categoryManager
            //                                                   .GetAll()
            //                                                   .Select(c => new SelectListItem()
            //                                                   {
            //                                                       Value = c.Id.ToString(),
            //                                                       Text = c.Name
            //                                                   }).ToList();
            //purchaseViewModel.ProductSelectListItems = _productManager
            //                                                   .GetAll()
            //                                                   .Select(c => new SelectListItem()
            //                                                   {
            //                                                       Value = c.Id.ToString(),
            //                                                       Text = c.Name
            //                                                   }).ToList();

            return View(purchaseViewModel);
        }

        [HttpPost]
        public ActionResult AddPurchase(PurchaseViewModel purchaseViewModel)
        {
            Purchase purchase = Mapper.Map<Purchase>(purchaseViewModel);
            _purchaseManager.Add(purchase);

            purchaseViewModel.SupplierSelectListItems = _supplierManager
                                                       .GetAll()
                                                       .Select(c => new SelectListItem()
                                                       {
                                                           Value = c.Id.ToString(),
                                                           Text = c.Name
                                                       }).ToList();

            return View(purchaseViewModel);
        }
    }
}