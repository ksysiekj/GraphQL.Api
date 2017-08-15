using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductSubcategoryMap : IEntityTypeConfiguration<ProductSubcategory>
    {
        public void Map(EntityTypeBuilder<ProductSubcategory> builder)
        {
            // table
            builder.ToTable("ProductSubcategory", "Production");

            // keys
            builder.HasKey(t => t.ProductSubcategoryID);

            // Properties
            builder.Property(t => t.ProductSubcategoryID)
                .HasColumnName("ProductSubcategoryID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ProductCategoryID)
                .HasColumnName("ProductCategoryID")
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.ProductCategory)
                .WithMany(t => t.ProductSubcategories)
                .HasForeignKey(d => d.ProductCategoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
