using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesTerritory
    {
        public SalesTerritory()
        {
            SalesYTD = (System.Decimal)0.00;
            SalesLastYear = (System.Decimal)0.00;
            CostYTD = (System.Decimal)0.00;
            CostLastYear = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            StateProvinces = new List<StateProvince>();
            Customers = new List<Customer>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPeople = new List<SalesPerson>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
        }

        public virtual int TerritoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual string CountryRegionCode { get; set; }
        public virtual string Group { get; set; }
        public virtual decimal SalesYTD { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual decimal CostYTD { get; set; }
        public virtual decimal CostLastYear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPerson> SalesPeople { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
    }
}