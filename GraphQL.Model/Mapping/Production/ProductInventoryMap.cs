using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductInventoryMap : IEntityTypeConfiguration<ProductInventory>
    {
        public void Map(EntityTypeBuilder<ProductInventory> builder)
        {
            // table
            builder.ToTable("ProductInventory", "Production");

            // keys
            builder.HasKey(t => new { t.ProductID, t.LocationID });

            // Properties
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .IsRequired();
            builder.Property(t => t.Shelf)
                .HasColumnName("Shelf")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(t => t.Bin)
                .HasColumnName("Bin")
                .IsRequired();
            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Location)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.LocationID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
