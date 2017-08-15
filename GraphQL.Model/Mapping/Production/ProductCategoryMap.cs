using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Map(EntityTypeBuilder<ProductCategory> builder)
        {
            // table
            builder.ToTable("ProductCategory", "Production");

            // keys
            builder.HasKey(t => t.ProductCategoryID);

            // Properties
            builder.Property(t => t.ProductCategoryID)
                .HasColumnName("ProductCategoryID")
                .ValueGeneratedOnAdd()
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
        }
    }
}
