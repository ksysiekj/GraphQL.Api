using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class StateProvinceMap : IEntityTypeConfiguration<StateProvince>
    {
        public void Map(EntityTypeBuilder<StateProvince> builder)
        {
            // table
            builder.ToTable("StateProvince", "Person");

            // keys
            builder.HasKey(t => t.StateProvinceID);

            // Properties
            builder.Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.StateProvinceCode)
                .HasColumnName("StateProvinceCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.CountryRegionCode)
                .HasColumnName("CountryRegionCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.IsOnlyStateProvinceFlag)
                .HasColumnName("IsOnlyStateProvinceFlag")
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.CountryRegion)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.CountryRegionCode)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
