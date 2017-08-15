using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Purchasing;
using GraphQL.Model.Entities.Sales;

namespace GraphQL.Model.Entities.Person
{
    public class AddressType
    {
        public AddressType()
        {
            ModifiedDate = DateTime.Now;
            VendorAddresses = new List<VendorAddress>();
            CustomerAddresses = new List<CustomerAddress>();
        }

        public virtual int AddressTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}