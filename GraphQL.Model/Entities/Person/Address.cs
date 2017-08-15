using GraphQL.Model.Entities.Human;
using GraphQL.Model.Entities.Purchasing;
using GraphQL.Model.Entities.Sales;
using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Person
{
    public class Address
    {
        public Address()
        {
            ModifiedDate = DateTime.Now;
            Employees = new List<Employee>();
            VendorAddresses = new List<VendorAddress>();
            CustomerAddresses = new List<CustomerAddress>();
            //BillToSalesOrderHeaders = new List<SalesOrderHeader>();
            // ShipToSalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int AddressID { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual int StateProvinceID { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        //public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }
        //public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }
    }
}