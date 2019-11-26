﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheUCFour.Repository.Repository;
using TheUCFour.Model.Model;

namespace TheUCFour.BLL.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public bool Add(Purchase purchase)
        {
            return _purchaseRepository.Add(purchase);
        }
    }
}
