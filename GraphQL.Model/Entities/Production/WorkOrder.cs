﻿using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class WorkOrder
    {
        public WorkOrder()
        {
            ModifiedDate = DateTime.Now;
            WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public virtual int WorkOrderID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int OrderQty { get; set; }
        public virtual int StockedQty { get; set; }
        public virtual short ScrappedQty { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime? EndDate { get; set; }
        public virtual System.DateTime DueDate { get; set; }
        public virtual short? ScrapReasonID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}