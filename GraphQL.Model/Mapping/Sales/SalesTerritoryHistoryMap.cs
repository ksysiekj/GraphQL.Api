using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesTerritoryHistoryMap : IEntityTypeConfiguration<SalesTerritoryHistory>
    {
        public void Map(EntityTypeBuilder<SalesTerritoryHistory> builder)
        {
            // table
            builder.ToTable("SalesTerritoryHistory", "Sales");

            // keys
            builder.HasKey(t => new { t.SalesPersonID, t.TerritoryID, t.StartDate });

            // Properties
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .IsRequired();
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.SalesPersonID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
