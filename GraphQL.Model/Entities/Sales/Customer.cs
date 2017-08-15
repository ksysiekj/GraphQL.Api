using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class Customer
    {
        public Customer()
        {
            ModifiedDate = DateTime.Now;
            CustomerAddresses = new List<CustomerAddress>();
            Individuals = new List<Individual>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            Stores = new List<Store>();
        }

        public virtual int CustomerID { get; set; }
        public virtual int? TerritoryID { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string CustomerType { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}