using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Purchasing;
using GraphQL.Model.Entities.Sales;

namespace GraphQL.Model.Entities.Person
{
    public class ContactType
    {
        public ContactType()
        {
            ModifiedDate = DateTime.Now;
            VendorContacts = new List<VendorContact>();
            StoreContacts = new List<StoreContact>();
        }

        public virtual int ContactTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<VendorContact> VendorContacts { get; set; }
        public virtual ICollection<StoreContact> StoreContacts { get; set; }
    }
}