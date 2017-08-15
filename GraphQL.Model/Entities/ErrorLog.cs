using System;

namespace GraphQL.Model.Entities
{
    public class ErrorLog
    {
        public ErrorLog()
        {
            ErrorTime = DateTime.Now;
        }

        public virtual int ErrorLogID { get; set; }
        public virtual System.DateTime ErrorTime { get; set; }
        public virtual string UserName { get; set; }
        public virtual int ErrorNumber { get; set; }
        public virtual int? ErrorSeverity { get; set; }
        public virtual int? ErrorState { get; set; }
        public virtual string ErrorProcedure { get; set; }
        public virtual int? ErrorLine { get; set; }
        public virtual string ErrorMessage { get; set; }

    }
}