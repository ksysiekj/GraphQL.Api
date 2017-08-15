using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductModelMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Map(EntityTypeBuilder<ProductModel> builder)
        {
            // table
            builder.ToTable("ProductModel", "Production");

            // keys
            builder.HasKey(t => t.ProductModelID);

            // Properties
            builder.Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.CatalogDescription)
                .HasColumnName("CatalogDescription")
                ;
            builder.Property(t => t.Instructions)
                .HasColumnName("Instructions")
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
