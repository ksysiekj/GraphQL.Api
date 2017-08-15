using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductDescriptionMap : IEntityTypeConfiguration<ProductDescription>
    {
        public void Map(EntityTypeBuilder<ProductDescription> builder)
        {
            // table
            builder.ToTable("ProductDescription", "Production");

            // keys
            builder.HasKey(t => t.ProductDescriptionID);

            // Properties
            builder.Property(t => t.ProductDescriptionID)
                .HasColumnName("ProductDescriptionID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(400)
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
