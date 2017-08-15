using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class StoreContactMap : IEntityTypeConfiguration<StoreContact>
    {
        public void Map(EntityTypeBuilder<StoreContact> builder)
        {
            // table
            builder.ToTable("StoreContact", "Sales");

            // keys
            builder.HasKey(t => new { t.CustomerID, t.ContactID });

            // Properties
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            builder.Property(t => t.ContactID)
                .HasColumnName("ContactID")
                .IsRequired();
            builder.Property(t => t.ContactTypeID)
                .HasColumnName("ContactTypeID")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Contact)
                .WithMany(t => t.StoreContacts)
                .HasForeignKey(d => d.ContactID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ContactType)
                .WithMany(t => t.StoreContacts)
                .HasForeignKey(d => d.ContactTypeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Store)
                .WithMany(t => t.StoreContacts)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
