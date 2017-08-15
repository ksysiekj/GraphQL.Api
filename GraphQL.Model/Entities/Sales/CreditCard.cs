using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class CreditCard
    {
        public CreditCard()
        {
            ModifiedDate = DateTime.Now;
            Contacts = new List<Contact>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int CreditCardID { get; set; }
        public virtual string CardType { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual byte ExpMonth { get; set; }
        public virtual short ExpYear { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}