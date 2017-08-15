using System;

namespace GraphQL.Model.Entities.Production
{
    public class ProductInventory
    {
        public ProductInventory()
        {
            Quantity = 0;
            ModifiedDate = DateTime.Now;
        }

        public virtual int ProductID { get; set; }
        public virtual short LocationID { get; set; }
        public virtual string Shelf { get; set; }
        public virtual byte Bin { get; set; }
        public virtual short Quantity { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}