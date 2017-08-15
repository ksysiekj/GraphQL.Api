using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ProductDescription
    {
        public ProductDescription()
        {
            ModifiedDate = DateTime.Now;
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public virtual int ProductDescriptionID { get; set; }
        public virtual string Description { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}