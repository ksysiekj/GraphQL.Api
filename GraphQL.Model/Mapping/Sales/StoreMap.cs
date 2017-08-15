using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class StoreMap : IEntityTypeConfiguration<Store>
    {
        public void Map(EntityTypeBuilder<Store> builder)
        {
            // table
            builder.ToTable("Store", "Sales");

            // keys
            builder.HasKey(t => t.CustomerID);

            // Properties
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                ;
            builder.Property(t => t.Demographics)
                .HasColumnName("Demographics")
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.SalesPersonID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
