using GraphQL.Model.Entities.Purchasing;
using GraphQL.Model.Entities.Sales;
using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class Product
    {
        public Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            ModifiedDate = DateTime.Now;
            ComponentBillOfMaterials = new List<BillOfMaterials>();
            AssemblyBillOfMaterials = new List<BillOfMaterials>();
            ProductCostHistories = new List<ProductCostHistory>();
            Documents = new List<Document>();
            ProductInventories = new List<ProductInventory>();
            ProductListPriceHistories = new List<ProductListPriceHistory>();
            // ProductPhotos = new List<ProductPhoto>();
            ProductReviews = new List<ProductReview>();
            TransactionHistories = new List<TransactionHistory>();
            WorkOrders = new List<WorkOrder>();
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            ShoppingCartItems = new List<ShoppingCartItem>();
            //SpecialOffers = new List<SpecialOffer>();
        }

        public virtual int ProductID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual bool MakeFlag { get; set; }
        public virtual bool FinishedGoodsFlag { get; set; }
        public virtual string Color { get; set; }
        public virtual short SafetyStockLevel { get; set; }
        public virtual short ReorderPoint { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual string Size { get; set; }
        public virtual string SizeUnitMeasureCode { get; set; }
        public virtual string WeightUnitMeasureCode { get; set; }
        public virtual decimal? Weight { get; set; }
        public virtual int DaysToManufacture { get; set; }
        public virtual string ProductLine { get; set; }
        public virtual string Class { get; set; }
        public virtual string Style { get; set; }
        public virtual int? ProductSubcategoryID { get; set; }
        public virtual int? ProductModelID { get; set; }
        public virtual System.DateTime SellStartDate { get; set; }
        public virtual System.DateTime? SellEndDate { get; set; }
        public virtual System.DateTime? DiscontinuedDate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterials> ComponentBillOfMaterials { get; set; }
        public virtual ICollection<BillOfMaterials> AssemblyBillOfMaterials { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        //public virtual UnitMeasure SizeUnitMeasure { get; set; }
        //public virtual UnitMeasure WeightUnitMeasure { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        //public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
        //public virtual ICollection<SpecialOffer> SpecialOffers { get; set; }
    }
}