using System;
using GraphQL.Model.Entities.Purchasing;

namespace GraphQL.Model.Entities.Production
{
    public class ProductVendor
    {
        public ProductVendor()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int ProductID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int AverageLeadTime { get; set; }
        public virtual decimal StandardPrice { get; set; }
        public virtual decimal? LastReceiptCost { get; set; }
        public virtual System.DateTime? LastReceiptDate { get; set; }
        public virtual int MinOrderQty { get; set; }
        public virtual int MaxOrderQty { get; set; }
        public int? OnOrderQty { get; set; }
        public virtual string UnitMeasureCode { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}