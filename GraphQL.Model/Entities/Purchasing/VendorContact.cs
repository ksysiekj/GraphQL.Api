using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Purchasing
{
    public class VendorContact
    {
        public VendorContact()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int VendorID { get; set; }
        public virtual int ContactID { get; set; }
        public virtual int ContactTypeID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}