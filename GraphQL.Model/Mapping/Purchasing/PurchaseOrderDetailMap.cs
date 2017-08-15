using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class PurchaseOrderDetailMap : IEntityTypeConfiguration<PurchaseOrderDetail>
    {
        public void Map(EntityTypeBuilder<PurchaseOrderDetail> builder)
        {
            // table
            builder.ToTable("PurchaseOrderDetail", "Purchasing");

            // keys
            builder.HasKey(t => new { t.PurchaseOrderID, t.PurchaseOrderDetailID });

            // Properties
            builder.Property(t => t.PurchaseOrderID)
                .HasColumnName("PurchaseOrderID")
                .IsRequired();
            builder.Property(t => t.PurchaseOrderDetailID)
                .HasColumnName("PurchaseOrderDetailID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();
            builder.Property(t => t.OrderQty)
                .HasColumnName("OrderQty")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.UnitPrice)
                .HasColumnName("UnitPrice")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.LineTotal)
                .HasColumnName("LineTotal")
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ReceivedQty)
                .HasColumnName("ReceivedQty")
                .HasColumnType("decimal(8,2)")
                .IsRequired();
            builder.Property(t => t.RejectedQty)
                .HasColumnName("RejectedQty")
                .HasColumnType("decimal(8,2)")
                .IsRequired();
            builder.Property(t => t.StockedQty)
                .HasColumnName("StockedQty")
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("decimal(9,2)")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.PurchaseOrderHeader)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
