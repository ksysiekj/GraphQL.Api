using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class CustomerAddress
    {
        public CustomerAddress()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int CustomerID { get; set; }
        public virtual int AddressID { get; set; }
        public virtual int AddressTypeID { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}