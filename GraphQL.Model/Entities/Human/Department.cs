using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Model.Entities.Human
{
    public class Department
    {
        public Department()
        {
            ModifiedDate = DateTime.Now;
           // EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
        public virtual short DepartmentID { get; set; }
        public virtual string Name { get; set; }
        public virtual string GroupName { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

       // public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}