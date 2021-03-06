using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Entities
{
    public class MetadataField
    {
        public MetadataField()
        {
            
        }

        public int Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CreatedUserId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedUserId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Name { get; set; }

        public Nullable<int> ModuleId { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string Expression { get; set; }

    }
}
