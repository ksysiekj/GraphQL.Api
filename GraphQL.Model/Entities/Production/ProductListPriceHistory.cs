using System;

namespace GraphQL.Model.Entities.Production
{
    public class ProductListPriceHistory
    {
        public ProductListPriceHistory()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int ProductID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime? EndDate { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}