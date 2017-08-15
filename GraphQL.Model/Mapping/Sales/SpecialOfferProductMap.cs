using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SpecialOfferProductMap : IEntityTypeConfiguration<SpecialOfferProduct>
    {
        public void Map(EntityTypeBuilder<SpecialOfferProduct> builder)
        {
            // table
            builder.ToTable("SpecialOfferProduct", "Sales");

            // keys
            builder.HasKey(t => new { t.SpecialOfferID, t.ProductID });

            // Properties
            builder.Property(t => t.SpecialOfferID)
                .HasColumnName("SpecialOfferID")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
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
