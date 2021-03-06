using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Sale.Entities.Mapping
{
    public class PhysicalInventoryDetailMap : EntityTypeConfiguration<PhysicalInventoryDetail>
    {
        public PhysicalInventoryDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Note).HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Sale_PhysicalInventoryDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUserId).HasColumnName("ModifiedUserId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            this.Property(t => t.PhysicalInventoryId).HasColumnName("PhysicalInventoryId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.QuantityInInventory).HasColumnName("QuantityInInventory");
            this.Property(t => t.QuantityRemaining).HasColumnName("QuantityRemaining");
            this.Property(t => t.QuantityDiff).HasColumnName("QuantityDiff");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.ReferenceVoucher).HasColumnName("ReferenceVoucher");
        }
    }
}
