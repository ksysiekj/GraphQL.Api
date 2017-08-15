using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            ModifiedDate = DateTime.Now;
            ProductSubcategories = new List<ProductSubcategory>();
        }

        public virtual int ProductCategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}