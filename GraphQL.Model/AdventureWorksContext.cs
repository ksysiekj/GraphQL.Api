using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Model
{
    public class AdventureWorksDbContext : DbContext
    {
        public AdventureWorksDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEntityTypeConfiguration();

            base.OnModelCreating(modelBuilder);

        }

        //public DbSet<AWBuildVersion> AWBuildVersions { get; set; }
        //public DbSet<DatabaseLog> DatabaseLogs { get; set; }
        //public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Address> Address { get; set; }
        // public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        // public DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }
        //public DbSet<StateProvince> StateProvinces { get; set; }
        //public DbSet<AddressType> AddressTypes { get; set; }
        //public DbSet<ContactType> ContactTypes { get; set; }
        //public DbSet<CountryRegion> CountryRegions { get; set; }
        //public DbSet<SalesTerritory> SalesTerritories { get; set; }
        //public DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<UnitMeasure> UnitMeasures { get; set; }
        //public DbSet<Culture> Cultures { get; set; }
        //public DbSet<Document> Documents { get; set; }
        //public DbSet<Illustration> Illustrations { get; set; }
        //public DbSet<Location> Locations { get; set; }
        //public DbSet<ProductModel> ProductModels { get; set; }
        //public DbSet<ProductSubcategory> ProductSubcategories { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        //public DbSet<ProductDescription> ProductDescriptions { get; set; }
        //public DbSet<ProductInventory> ProductInventories { get; set; }
        //public DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        //public DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        //public DbSet<ProductPhoto> ProductPhotos { get; set; }
        //public DbSet<ProductReview> ProductReviews { get; set; }
        //public DbSet<ScrapReason> ScrapReasons { get; set; }
        //public DbSet<TransactionHistory> TransactionHistories { get; set; }
        //public DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        //public DbSet<WorkOrder> WorkOrders { get; set; }
        //public DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
        //public DbSet<ProductVendor> ProductVendors { get; set; }
        //public DbSet<Vendor> Vendors { get; set; }
        //public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        //public DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        //public DbSet<ShipMethod> ShipMethods { get; set; }
        //public DbSet<VendorAddress> VendorAddresses { get; set; }
        //public DbSet<VendorContact> VendorContacts { get; set; }
        //public DbSet<CreditCard> CreditCards { get; set; }
        //public DbSet<Currency> Currencies { get; set; }
        //public DbSet<CurrencyRate> CurrencyRates { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        //public DbSet<Individual> Individuals { get; set; }
        //public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        //public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        //public DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        //public DbSet<SalesPerson> SalesPeople { get; set; }
        //public DbSet<SalesReason> SalesReasons { get; set; }
        //public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        //public DbSet<SalesTaxRate> SalesTaxRates { get; set; }
        //public DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        //public DbSet<SpecialOffer> SpecialOffers { get; set; }
        //public DbSet<Store> Stores { get; set; }
        //public DbSet<StoreContact> StoreContacts { get; set; }
    }
}
