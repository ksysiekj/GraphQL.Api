using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            ModifiedDate = DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public virtual int SpecialOfferID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}