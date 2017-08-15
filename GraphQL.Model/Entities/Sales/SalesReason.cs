using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesReason
    {
        public SalesReason()
        {
            ModifiedDate = DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int SalesReasonID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ReasonType { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}