using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Sales;

namespace GraphQL.Model.Entities.Person
{
    public class StateProvince
    {
        public StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            ModifiedDate = DateTime.Now;
            Address = new List<Address>();
            SalesTaxRates = new List<SalesTaxRate>();
        }

        public virtual int StateProvinceID { get; set; }
        public virtual string StateProvinceCode { get; set; }
        public virtual string CountryRegionCode { get; set; }
        public virtual bool IsOnlyStateProvinceFlag { get; set; }
        public virtual string Name { get; set; }
        public virtual int TerritoryID { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }
    }
}