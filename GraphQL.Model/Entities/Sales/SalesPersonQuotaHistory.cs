using System;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesPersonQuotaHistory
    {
        public SalesPersonQuotaHistory()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int SalesPersonID { get; set; }
        public virtual System.DateTime QuotaDate { get; set; }
        public virtual decimal SalesQuota { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
    }
}