using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Sales;

namespace GraphQL.Model.Entities.Purchasing
{
    public class ShipMethod
    {
        public ShipMethod()
        {
            ShipBase = (System.Decimal)0.00;
            ShipRate = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int ShipMethodID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal ShipBase { get; set; }
        public virtual decimal ShipRate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}