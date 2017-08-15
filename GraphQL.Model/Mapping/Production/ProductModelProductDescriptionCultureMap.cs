using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductModelProductDescriptionCultureMap : IEntityTypeConfiguration<ProductModelProductDescriptionCulture>
    {
        public void Map(EntityTypeBuilder<ProductModelProductDescriptionCulture> builder)
        {
            // table
            builder.ToTable("ProductModelProductDescriptionCulture", "Production");

            // keys
            builder.HasKey(t => new { t.ProductModelID, t.ProductDescriptionID, t.CultureID });

            // Properties
            builder.Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                .IsRequired();
            builder.Property(t => t.ProductDescriptionID)
                .HasColumnName("ProductDescriptionID")
                .IsRequired();
            builder.Property(t => t.CultureID)
                .HasColumnName("CultureID")
                .HasMaxLength(6)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Culture)
                .WithMany(t => t.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.CultureID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ProductDescription)
                .WithMany(t => t.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.ProductDescriptionID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.ProductModelProductDescriptionCultures)
                .HasForeignKey(d => d.ProductModelID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
