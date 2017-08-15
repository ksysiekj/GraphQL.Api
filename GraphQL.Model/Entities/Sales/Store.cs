using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class Store
    {
        public Store()
        {
            ModifiedDate = DateTime.Now;
            StoreContacts = new List<StoreContact>();
        }

        public virtual int CustomerID { get; set; }
        public virtual string Name { get; set; }
        public virtual int? SalesPersonID { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<StoreContact> StoreContacts { get; set; }
    }
}