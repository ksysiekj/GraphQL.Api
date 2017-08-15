using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Model.Entities.Human
{
    public class EmployeeDepartmentHistory
    {
        public EmployeeDepartmentHistory()
        {
            ModifiedDate = DateTime.Now;
        }
        public virtual int EmployeeID { get; set; }
        public virtual short DepartmentID { get; set; }
        public virtual byte ShiftID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime? EndDate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}