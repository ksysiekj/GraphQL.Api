using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ProductSubcategory
    {
        public ProductSubcategory()
        {
            ModifiedDate = DateTime.Now;
            Products = new List<Product>();
        }

        public virtual int ProductSubcategoryID { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}