using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class CustomerAddressMap : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Map(EntityTypeBuilder<CustomerAddress> builder)
        {
            // table
            builder.ToTable("CustomerAddress", "Sales");

            // keys
            builder.HasKey(t => new { t.CustomerID, t.AddressID });

            // Properties
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            builder.Property(t => t.AddressID)
                .HasColumnName("AddressID")
                .IsRequired();
            builder.Property(t => t.AddressTypeID)
                .HasColumnName("AddressTypeID")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Address)
                .WithMany(t => t.CustomerAddresses)
                .HasForeignKey(d => d.AddressID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.AddressType)
                .WithMany(t => t.CustomerAddresses)
                .HasForeignKey(d => d.AddressTypeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.CustomerAddresses)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
