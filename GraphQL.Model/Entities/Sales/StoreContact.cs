using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class StoreContact
    {
        public StoreContact()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int CustomerID { get; set; }
        public virtual int ContactID { get; set; }
        public virtual int ContactTypeID { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Store Store { get; set; }
    }
}