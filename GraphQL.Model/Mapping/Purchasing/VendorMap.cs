using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class VendorMap : IEntityTypeConfiguration<Vendor>
    {
        public void Map(EntityTypeBuilder<Vendor> builder)
        {
            // table
            builder.ToTable("Vendor", "Purchasing");

            // keys
            builder.HasKey(t => t.VendorID);

            // Properties
            builder.Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.CreditRating)
                .HasColumnName("CreditRating")
                .IsRequired();
            builder.Property(t => t.PreferredVendorStatus)
                .HasColumnName("PreferredVendorStatus")
                .IsRequired();
            builder.Property(t => t.ActiveFlag)
                .HasColumnName("ActiveFlag")
                .IsRequired();
            builder.Property(t => t.PurchasingWebServiceURL)
                .HasColumnName("PurchasingWebServiceURL")
                .HasMaxLength(1024)
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
