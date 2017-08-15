using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class CurrencyMap : IEntityTypeConfiguration<Currency>
    {
        public void Map(EntityTypeBuilder<Currency> builder)
        {
            // table
            builder.ToTable("Currency", "Sales");

            // keys
            builder.HasKey(t => t.CurrencyCode);

            // Properties
            builder.Property(t => t.CurrencyCode)
                .HasColumnName("CurrencyCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
