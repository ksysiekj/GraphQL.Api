using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class Culture
    {
        public Culture()
        {
            ModifiedDate = DateTime.Now;
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public virtual string CultureID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}