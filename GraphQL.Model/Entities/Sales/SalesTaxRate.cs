using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesTaxRate
    {
        public SalesTaxRate()
        {
            TaxRate = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
        }

        public virtual int SalesTaxRateID { get; set; }
        public virtual int StateProvinceID { get; set; }
        public virtual byte TaxType { get; set; }
        public virtual decimal TaxRate { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }
    }
}