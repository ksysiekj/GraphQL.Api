using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ScrapReason
    {
        public ScrapReason()
        {
            ModifiedDate = DateTime.Now;
            WorkOrders = new List<WorkOrder>();
        }

        public virtual short ScrapReasonID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}