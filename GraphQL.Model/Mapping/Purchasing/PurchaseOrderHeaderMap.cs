using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class PurchaseOrderHeaderMap : IEntityTypeConfiguration<PurchaseOrderHeader>
    {
        public void Map(EntityTypeBuilder<PurchaseOrderHeader> builder)
        {
            // table
            builder.ToTable("PurchaseOrderHeader", "Purchasing");

            // keys
            builder.HasKey(t => t.PurchaseOrderID);

            // Properties
            builder.Property(t => t.PurchaseOrderID)
                .HasColumnName("PurchaseOrderID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.RevisionNumber)
                .HasColumnName("RevisionNumber")
                .IsRequired();
            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            builder.Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .IsRequired();
            builder.Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            builder.Property(t => t.ShipMethodID)
                .HasColumnName("ShipMethodID")
                .IsRequired();
            builder.Property(t => t.OrderDate)
                .HasColumnName("OrderDate")
                .IsRequired();
            builder.Property(t => t.ShipDate)
                .HasColumnName("ShipDate")
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
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ShipMethod)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
