using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class UnitMeasure
    {
        public UnitMeasure()
        {
            ModifiedDate = DateTime.Now;
            BillOfMaterials = new List<BillOfMaterials>();
            SizeProducts = new List<Product>();
            WeightProducts = new List<Product>();
            ProductVendors = new List<ProductVendor>();
        }

        public virtual string UnitMeasureCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual ICollection<Product> SizeProducts { get; set; }
        public virtual ICollection<Product> WeightProducts { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
    }
}