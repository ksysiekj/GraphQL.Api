using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class VendorAddressMap : IEntityTypeConfiguration<VendorAddress>
    {
        public void Map(EntityTypeBuilder<VendorAddress> builder)
        {
            // table
            builder.ToTable("VendorAddress", "Purchasing");

            // keys
            builder.HasKey(t => new { t.VendorID, t.AddressID });

            // Properties
            builder.Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            builder.Property(t => t.AddressID)
                .HasColumnName("AddressID")
                .IsRequired();
            builder.Property(t => t.AddressTypeID)
                .HasColumnName("AddressTypeID")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Address)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.AddressID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.AddressType)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.AddressTypeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.VendorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
