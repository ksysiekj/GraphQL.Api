using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ProductModel
    {
        public ProductModel()
        {
            ModifiedDate = DateTime.Now;
            Products = new List<Product>();
            Illustrations = new List<Illustration>();
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public virtual int ProductModelID { get; set; }
        public virtual string Name { get; set; }
        public virtual string CatalogDescription { get; set; }
        public virtual string Instructions { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Illustration> Illustrations { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}