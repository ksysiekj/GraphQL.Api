using GraphQL.Model.Entities.Person;
using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class Currency
    {
        public Currency()
        {
            ModifiedDate = DateTime.Now;
            CountryRegions = new List<CountryRegion>();
            //FromCurrencyRates = new List<CurrencyRate>();
            ToCurrencyRates = new List<CurrencyRate>();
        }

        public virtual string CurrencyCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegion> CountryRegions { get; set; }
        // public virtual ICollection<CurrencyRate> FromCurrencyRates { get; set; }
        public virtual ICollection<CurrencyRate> ToCurrencyRates { get; set; }
    }
}