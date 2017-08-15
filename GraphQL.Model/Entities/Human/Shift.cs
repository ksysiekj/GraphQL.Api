using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Model.Entities.Human
{
    public class Shift
    {
        public Shift()
        {
            ModifiedDate = DateTime.Now;
           // EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
        [Key]
        public virtual byte ShiftID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime StartTime { get; set; }
        public virtual System.DateTime EndTime { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        //public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}