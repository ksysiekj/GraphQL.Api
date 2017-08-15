using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesTerritoryMap : IEntityTypeConfiguration<SalesTerritory>
    {
        public void Map(EntityTypeBuilder<SalesTerritory> builder)
        {
            // table
            builder.ToTable("SalesTerritory", "Sales");

            // keys
            builder.HasKey(t => t.TerritoryID);

            // Properties
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.CountryRegionCode)
                .HasColumnName("CountryRegionCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.Group)
                .HasColumnName("Group")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.SalesYTD)
                .HasColumnName("SalesYTD")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.SalesLastYear)
                .HasColumnName("SalesLastYear")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.CostYTD)
                .HasColumnName("CostYTD")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.CostLastYear)
                .HasColumnName("CostLastYear")
                .HasColumnType("decimal(19,4)")
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
