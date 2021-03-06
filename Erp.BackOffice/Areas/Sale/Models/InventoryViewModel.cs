using Erp.BackOffice.App_GlobalResources;
using Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Erp.BackOffice.Sale.Models
{
    public class InventoryViewModel
    {
        public int Id { get; set; }

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; }

        [Display(Name = "CreatedUser", ResourceType = typeof(Wording))]
        public int? CreatedUserId { get; set; }
        public string CreatedUserName { get; set; }

        [Display(Name = "CreatedDate", ResourceType = typeof(Wording))]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "ModifiedUser", ResourceType = typeof(Wording))]
        public int? ModifiedUserId { get; set; }
        public string ModifiedUserName { get; set; }

        [Display(Name = "ModifiedDate", ResourceType = typeof(Wording))]
        public DateTime? ModifiedDate { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "Warehouse", ResourceType = typeof(Wording))]
        public Nullable<int> WarehouseId { get; set; }
        [Display(Name = "Warehouse", ResourceType = typeof(Wording))]
        public string WarehouseName { get; set; }
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "ProductName", ResourceType = typeof(Wording))]
        public Nullable<int> ProductId { get; set; }
        [Display(Name = "ProductName", ResourceType = typeof(Wording))]
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        [Display(Name = "Quantity", ResourceType = typeof(Wording))]
        public Nullable<int> Quantity { get; set; }
        [Display(Name = "PriceInbound", ResourceType = typeof(Wording))]
        public decimal? ProductPriceInbound { get; set; }

        [Display(Name = "PriceOutbound", ResourceType = typeof(Wording))]
        public decimal? ProductPriceOutbound { get; set; }

        [Display(Name = "Unit", ResourceType = typeof(Wording))]
        public string Unit { get; set; }
        [Display(Name = "QtyInbound", ResourceType = typeof(Wording))]
        public Nullable<int> QtyInbound { get; set; }
        [Display(Name = "QtyOutbound", ResourceType = typeof(Wording))]
        public Nullable<int> QtyOutbound { get; set; }
        public Nullable<int> CBTK { get; set; }
        public int? ProductMinInventory { get; set; }
        public int? ProductMinInventoryAlarms { get; set; }
        public string StatusInventory { get; set; }
    }
}