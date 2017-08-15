using System;
using System.Collections.Generic;
using GraphQL.Model.Entities.Production;

namespace GraphQL.Model.Entities.Purchasing
{
    public class Vendor
    {
        public Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = DateTime.Now;
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            VendorAddresses = new List<VendorAddress>();
            VendorContacts = new List<VendorContact>();
        }

        public virtual int VendorID { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual byte CreditRating { get; set; }
        public virtual bool PreferredVendorStatus { get; set; }
        public virtual bool ActiveFlag { get; set; }
        public virtual string PurchasingWebServiceURL { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
    }
}