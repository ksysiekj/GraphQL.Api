using System;

namespace GraphQL.Model.Entities.Production
{
    public class TransactionHistoryArchive
    {
        public TransactionHistoryArchive()
        {
            ReferenceOrderLineID = 0;
            TransactionDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        public virtual int TransactionID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int ReferenceOrderID { get; set; }
        public virtual int ReferenceOrderLineID { get; set; }
        public virtual System.DateTime TransactionDate { get; set; }
        public virtual string TransactionType { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal ActualCost { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

    }
}