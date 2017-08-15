using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class VendorContactMap : IEntityTypeConfiguration<VendorContact>
    {
        public void Map(EntityTypeBuilder<VendorContact> builder)

        {
            // table
            builder.ToTable("VendorContact", "Purchasing");

            // keys
            builder.HasKey(t => new { t.VendorID, t.ContactID });

            // Properties
            builder.Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            builder.Property(t => t.ContactID)
                .HasColumnName("ContactID")
                .IsRequired();
            builder.Property(t => t.ContactTypeID)
                .HasColumnName("ContactTypeID")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Contact)
                .WithMany(t => t.VendorContacts)
                .HasForeignKey(d => d.ContactID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ContactType)
                .WithMany(t => t.VendorContacts)
                .HasForeignKey(d => d.ContactTypeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.VendorContacts)
                .HasForeignKey(d => d.VendorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
