using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Model.Entities.Human
{
    public class JobCandidate
    {
        public JobCandidate()
        {
            ModifiedDate = DateTime.Now;
        }
        [Key]
        public virtual int JobCandidateID { get; set; }
        public virtual int? EmployeeID { get; set; }
        public virtual string Resume { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}