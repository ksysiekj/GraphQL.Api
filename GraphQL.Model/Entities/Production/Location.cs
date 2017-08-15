using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class Location
    {
        public Location()
        {
            CostRate = (System.Decimal)0.00;
            Availability = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            ProductInventories = new List<ProductInventory>();
            WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public virtual short LocationID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal CostRate { get; set; }
        public virtual decimal Availability { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}