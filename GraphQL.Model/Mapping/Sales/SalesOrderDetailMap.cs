using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesOrderDetailMap : IEntityTypeConfiguration<SalesOrderDetail>
    {
        public void Map(EntityTypeBuilder<SalesOrderDetail> builder)
        {
            // table
            builder.ToTable("SalesOrderDetail", "Sales");

            // keys
            builder.HasKey(t => new { t.SalesOrderID, t.SalesOrderDetailID });

            // Properties
            builder.Property(t => t.SalesOrderID)
                .HasColumnName("SalesOrderID")
                .IsRequired();
            builder.Property(t => t.SalesOrderDetailID)
                .HasColumnName("SalesOrderDetailID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.CarrierTrackingNumber)
                .HasColumnName("CarrierTrackingNumber")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.OrderQty)
                .HasColumnName("OrderQty")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.SpecialOfferID)
                .HasColumnName("SpecialOfferID")
                .IsRequired();
            builder.Property(t => t.UnitPrice)
                .HasColumnName("UnitPrice")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.UnitPriceDiscount)
                .HasColumnName("UnitPriceDiscount")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.LineTotal)
                .HasColumnName("LineTotal")
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("decimal(38,6)")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.SalesOrderHeader)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.SalesOrderID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SpecialOfferProduct)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => new { d.SpecialOfferID, d.ProductID })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
