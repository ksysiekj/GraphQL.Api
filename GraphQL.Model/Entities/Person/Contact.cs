using GraphQL.Model.Entities.Human;
using GraphQL.Model.Entities.Purchasing;
using GraphQL.Model.Entities.Sales;
using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Person
{
    public class Contact
    {
        public Contact()
        {
            EmailPromotion = 0;
            ModifiedDate = DateTime.Now;
            Employees = new List<Employee>();
            VendorContacts = new List<VendorContact>();
            //CreditCards = new List<CreditCard>();
            Individuals = new List<Individual>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            StoreContacts = new List<StoreContact>();
        }

        public virtual int ContactID { get; set; }
        public virtual bool NameStyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int EmailPromotion { get; set; }
        public virtual string Phone { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string PasswordSalt { get; set; }
        public virtual string AdditionalContactInfo { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
        // public virtual ICollection<CreditCard> CreditCards { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<StoreContact> StoreContacts { get; set; }
    }
}