using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Production;

namespace GraphQL.Model.Entities.Sales
{
    public class SpecialOffer
    {
        public SpecialOffer()
        {
            DiscountPct = (System.Decimal)0.00;
            MinQty = 0;
            ModifiedDate = DateTime.Now;
            Products = new List<Product>();
        }

        public virtual int SpecialOfferID { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal DiscountPct { get; set; }
        public virtual string Type { get; set; }
        public virtual string Category { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime EndDate { get; set; }
        public virtual int MinQty { get; set; }
        public virtual int? MaxQty { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}