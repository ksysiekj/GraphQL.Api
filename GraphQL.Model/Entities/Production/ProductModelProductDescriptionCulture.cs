using System;

namespace GraphQL.Model.Entities.Production
{
    public class ProductModelProductDescriptionCulture
    {
        public ProductModelProductDescriptionCulture()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int ProductModelID { get; set; }
        public virtual int ProductDescriptionID { get; set; }
        public virtual string CultureID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Culture Culture { get; set; }
        public virtual ProductDescription ProductDescription { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}