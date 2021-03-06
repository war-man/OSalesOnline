using Erp.BackOffice.App_GlobalResources;
using Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Erp.BackOffice.Sale.Models
{
    public class spBaoCaoXuatViewModel
    {
        public string ProductInvoiceCode { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> ProductId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}