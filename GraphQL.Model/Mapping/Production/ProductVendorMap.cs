using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductVendorMap : IEntityTypeConfiguration<ProductVendor>
    {
        public void Map(EntityTypeBuilder<ProductVendor> builder)
        {
            // table
            builder.ToTable("ProductVendor", "Purchasing");

            // keys
            builder.HasKey(t => new { t.ProductID, t.VendorID });

            // Properties
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            builder.Property(t => t.AverageLeadTime)
                .HasColumnName("AverageLeadTime")
                .IsRequired();
            builder.Property(t => t.StandardPrice)
                .HasColumnName("StandardPrice")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.LastReceiptCost)
                .HasColumnName("LastReceiptCost")
                .HasColumnType("decimal(19,4)")
                ;
            builder.Property(t => t.LastReceiptDate)
                .HasColumnName("LastReceiptDate")
                ;
            builder.Property(t => t.MinOrderQty)
                .HasColumnName("MinOrderQty")
                .IsRequired();
            builder.Property(t => t.MaxOrderQty)
                .HasColumnName("MaxOrderQty")
                .IsRequired();
            builder.Property(t => t.OnOrderQty)
                .HasColumnName("OnOrderQty")
                ;
            builder.Property(t => t.UnitMeasureCode)
                .HasColumnName("UnitMeasureCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.UnitMeasure)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.UnitMeasureCode)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.VendorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
