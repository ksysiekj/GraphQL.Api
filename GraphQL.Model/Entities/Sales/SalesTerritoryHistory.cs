using System;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesTerritoryHistory
    {
        public SalesTerritoryHistory()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int SalesPersonID { get; set; }
        public virtual int TerritoryID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime? EndDate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}