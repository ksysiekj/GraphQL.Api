using System;
using GraphQL.Model.Entities.Person;

namespace GraphQL.Model.Entities.Sales
{
    public class Individual
    {
        public Individual()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual int CustomerID { get; set; }
        public virtual int ContactID { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Customer Customer { get; set; }
    }
}