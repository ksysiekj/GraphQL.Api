using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Human
{
    public class Employee
    {
        public Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            ModifiedDate = DateTime.Now;
            // ManagerEmployees = new List<Employee>();
            // Address = new List<Address>();
            //EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            //EmployeePayHistories = new List<EmployeePayHistory>();
            JobCandidates = new List<JobCandidate>();
            //PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            //SalesPeople = new List<SalesPerson>();
        }

        public virtual int EmployeeID { get; set; }
        public virtual string NationalIDNumber { get; set; }
        public virtual string Title { get; set; }
        public virtual System.DateTime BirthDate { get; set; }
        public virtual string MaritalStatus { get; set; }
        public virtual string Gender { get; set; }
        public virtual System.DateTime HireDate { get; set; }
        public virtual bool SalariedFlag { get; set; }
        public virtual short VacationHours { get; set; }
        public virtual short SickLeaveHours { get; set; }
        public virtual bool CurrentFlag { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        //public virtual Contact Contact { get; set; }
        //public virtual Employee ManagerEmployee { get; set; }
        //public virtual ICollection<Employee> ManagerEmployees { get; set; }
        // public virtual ICollection<Address> Address { get; set; }
        //public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        //public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }
        //public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        //public virtual ICollection<SalesPerson> SalesPeople { get; set; }
    }
}