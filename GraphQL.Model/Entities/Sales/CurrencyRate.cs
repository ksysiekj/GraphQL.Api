using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class CurrencyRate
    {
        public CurrencyRate()
        {
            ModifiedDate = DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int CurrencyRateID { get; set; }
        public virtual System.DateTime CurrencyRateDate { get; set; }
        public virtual string FromCurrencyCode { get; set; }
        public virtual string ToCurrencyCode { get; set; }
        public virtual decimal AverageRate { get; set; }
        public virtual decimal EndOfDayRate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Currency FromCurrency { get; set; }
        // public virtual Currency ToCurrency { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}