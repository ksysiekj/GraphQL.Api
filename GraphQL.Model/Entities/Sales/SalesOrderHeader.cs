using GraphQL.Model.Entities.Person;
using GraphQL.Model.Entities.Purchasing;
using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Sales
{
    public class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = (System.Decimal)0.00;
            TaxAmt = (System.Decimal)0.00;
            Freight = (System.Decimal)0.00;
            ModifiedDate = DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
            //SalesReasons = new List<SalesReason>();
        }

        public virtual int SalesOrderID { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual System.DateTime OrderDate { get; set; }
        public virtual System.DateTime DueDate { get; set; }
        public virtual System.DateTime? ShipDate { get; set; }
        public virtual byte Status { get; set; }
        public virtual bool OnlineOrderFlag { get; set; }
        public virtual string SalesOrderNumber { get; set; }
        public virtual string PurchaseOrderNumber { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual int ContactID { get; set; }
        public virtual int? SalesPersonID { get; set; }
        public virtual int? TerritoryID { get; set; }
        public virtual int BillToAddressID { get; set; }
        public virtual int ShipToAddressID { get; set; }
        public virtual int ShipMethodID { get; set; }
        public virtual int? CreditCardID { get; set; }
        public virtual string CreditCardApprovalCode { get; set; }
        public virtual int? CurrencyRateID { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual string Comment { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual Address BillToAddress { get; set; }
        public virtual Address ShipToAddress { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual CreditCard CreditCard { get; set; }
        public virtual CurrencyRate CurrencyRate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        //public virtual ICollection<SalesReason> SalesReasons { get; set; }
    }
}