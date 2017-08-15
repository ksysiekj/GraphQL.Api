using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Person
{
    public class CountryRegion
    {
        public CountryRegion()
        {
            ModifiedDate = DateTime.Now;
            StateProvinces = new List<StateProvince>();
            //Currencies = new List<Currency>();
        }

        public virtual string CountryRegionCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        //public virtual ICollection<Currency> Currencies { get; set; }
    }
}