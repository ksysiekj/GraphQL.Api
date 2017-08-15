using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Human;

namespace GraphQL.Model.Entities.Purchasing
{
    public class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = DateTime.Now;
            SubTotal = (System.Decimal)0.00;
            TaxAmt = (System.Decimal)0.00;
            Freight = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public virtual int PurchaseOrderID { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual int EmployeeID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ShipMethodID { get; set; }
        public virtual System.DateTime OrderDate { get; set; }
        public virtual System.DateTime? ShipDate { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}