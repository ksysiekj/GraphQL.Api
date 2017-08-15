using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Purchasing
{
    public class VendorAddress
    {
        public VendorAddress()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int VendorID { get; set; }
        public virtual int AddressID { get; set; }
        public virtual int AddressTypeID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}