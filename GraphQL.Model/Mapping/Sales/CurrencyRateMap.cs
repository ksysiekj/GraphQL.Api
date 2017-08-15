using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class CurrencyRateMap : IEntityTypeConfiguration<CurrencyRate>
    {
        public void Map(EntityTypeBuilder<CurrencyRate> builder)
        {
            // table
            builder.ToTable("CurrencyRate", "Sales");

            // keys
            builder.HasKey(t => t.CurrencyRateID);

            // Properties
            builder.Property(t => t.CurrencyRateID)
                .HasColumnName("CurrencyRateID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.CurrencyRateDate)
                .HasColumnName("CurrencyRateDate")
                .IsRequired();
            builder.Property(t => t.FromCurrencyCode)
                .HasColumnName("FromCurrencyCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.ToCurrencyCode)
                .HasColumnName("ToCurrencyCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.AverageRate)
                .HasColumnName("AverageRate")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.EndOfDayRate)
                .HasColumnName("EndOfDayRate")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasOne(t => t.FromCurrency)
            //    .WithMany(t => t.FromCurrencyRates)
            //    .HasForeignKey(d => d.FromCurrencyCode)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(t => t.ToCurrency)
            //    .WithMany(t => t.ToCurrencyRates)
            //    .HasForeignKey(d => d.ToCurrencyCode)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
