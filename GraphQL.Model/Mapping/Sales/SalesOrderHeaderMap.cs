using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesOrderHeaderMap : IEntityTypeConfiguration<SalesOrderHeader>
    {
        public void Map(EntityTypeBuilder<SalesOrderHeader> builder)
        {
            // table
            builder.ToTable("SalesOrderHeader", "Sales");

            // keys
            builder.HasKey(t => t.SalesOrderID);

            // Properties
            builder.Property(t => t.SalesOrderID)
                .HasColumnName("SalesOrderID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.RevisionNumber)
                .HasColumnName("RevisionNumber")
                .IsRequired();
            builder.Property(t => t.OrderDate)
                .HasColumnName("OrderDate")
                .IsRequired();
            builder.Property(t => t.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();
            builder.Property(t => t.ShipDate)
                .HasColumnName("ShipDate")
                ;
            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            builder.Property(t => t.OnlineOrderFlag)
                .HasColumnName("OnlineOrderFlag")
                .IsRequired();
            builder.Property(t => t.SalesOrderNumber)
                .HasColumnName("SalesOrderNumber")
                .ValueGeneratedOnAddOrUpdate()
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(t => t.PurchaseOrderNumber)
                .HasColumnName("PurchaseOrderNumber")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            builder.Property(t => t.ContactID)
                .HasColumnName("ContactID")
                .IsRequired();
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                ;
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                ;
            builder.Property(t => t.BillToAddressID)
                .HasColumnName("BillToAddressID")
                .IsRequired();
            builder.Property(t => t.ShipToAddressID)
                .HasColumnName("ShipToAddressID")
                .IsRequired();
            builder.Property(t => t.ShipMethodID)
                .HasColumnName("ShipMethodID")
                .IsRequired();
            builder.Property(t => t.CreditCardID)
                .HasColumnName("CreditCardID")
                ;
            builder.Property(t => t.CreditCardApprovalCode)
                .HasColumnName("CreditCardApprovalCode")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.CurrencyRateID)
                .HasColumnName("CurrencyRateID")
                ;
            builder.Property(t => t.SubTotal)
                .HasColumnName("SubTotal")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.TaxAmt)
                .HasColumnName("TaxAmt")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Freight)
                .HasColumnName("Freight")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.TotalDue)
                .HasColumnName("TotalDue")
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasOne(t => t.BillToAddress)
            //    .WithMany(t => t.BillToSalesOrderHeaders)
            //    .HasForeignKey(d => d.BillToAddressID)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(t => t.ShipToAddress)
            //    .WithMany(t => t.ShipToSalesOrderHeaders)
            //    .HasForeignKey(d => d.ShipToAddressID)
            //    .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Contact)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ContactID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.CreditCard)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CreditCardID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.CurrencyRate)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CurrencyRateID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.SalesPersonID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ShipMethod)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .OnDelete(DeleteBehavior.Restrict);
            //builder.HasMany(t => t.SalesReasons)
            //    .WithMany(t => t.SalesOrderHeaders)
            //    .Map(m =>
            //    {
            //        m.ToTable("SalesOrderHeaderSalesReason", "Sales");
            //        m.MapLeftKey("SalesOrderID");
            //        m.MapRightKey("SalesReasonID");
            //    });
        }
    }
}
