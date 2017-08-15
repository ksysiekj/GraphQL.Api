using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Human;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesPerson
    {
        public SalesPerson()
        {
            Bonus = (System.Decimal)0.00;
            CommissionPct = (System.Decimal)0.00;
            SalesYTD = (System.Decimal)0.00;
            SalesLastYear = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            Stores = new List<Store>();
        }

        public virtual int SalesPersonID { get; set; }
        public virtual int? TerritoryID { get; set; }
        public virtual decimal? SalesQuota { get; set; }
        public virtual decimal Bonus { get; set; }
        public virtual decimal CommissionPct { get; set; }
        public virtual decimal SalesYTD { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}