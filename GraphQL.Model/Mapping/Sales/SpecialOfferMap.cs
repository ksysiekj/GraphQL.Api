using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SpecialOfferMap : IEntityTypeConfiguration<SpecialOffer>
    {
        public void Map(EntityTypeBuilder<SpecialOffer> builder)
        {
            // table
            builder.ToTable("SpecialOffer", "Sales");

            // keys
            builder.HasKey(t => t.SpecialOfferID);

            // Properties
            builder.Property(t => t.SpecialOfferID)
                .HasColumnName("SpecialOfferID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(t => t.DiscountPct)
                .HasColumnName("DiscountPct")
                .HasColumnType("decimal(10,4)")
                .IsRequired();
            builder.Property(t => t.Type)
                .HasColumnName("Type")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Category)
                .HasColumnName("Category")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .IsRequired();
            builder.Property(t => t.MinQty)
                .HasColumnName("MinQty")
                .IsRequired();
            builder.Property(t => t.MaxQty)
                .HasColumnName("MaxQty")
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
