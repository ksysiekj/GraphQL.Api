using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class CountryRegionMap : IEntityTypeConfiguration<CountryRegion>

    {
        public void Map(EntityTypeBuilder<CountryRegion> builder)
        {
            // table
            builder.ToTable("CountryRegion", "Person");

            // keys
            builder.HasKey(t => t.CountryRegionCode);

            // Properties
            builder.Property(t => t.CountryRegionCode)
                .HasColumnName("CountryRegionCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasMany(t => t.Currencies)
            //    .WithMany(t => t.CountryRegions)
            //    .Map(m =>
            //    {
            //        m.ToTable("CountryRegionCurrency", "Sales");
            //        m.MapLeftKey("CountryRegionCode");
            //        m.MapRightKey("CurrencyCode");
            //    });
        }
    }
}
