using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Model.Entities.Human
{
    public class EmployeePayHistory
    {
        public EmployeePayHistory()
        {
            ModifiedDate = DateTime.Now;
        }
        public virtual int EmployeeID { get; set; }
        public virtual System.DateTime RateChangeDate { get; set; }
        public virtual decimal Rate { get; set; }
        public virtual byte PayFrequency { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}