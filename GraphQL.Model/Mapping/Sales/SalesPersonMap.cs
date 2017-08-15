using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesPersonMap : IEntityTypeConfiguration<SalesPerson>
    {
        public void Map(EntityTypeBuilder<SalesPerson> builder)
        {
            // table
            builder.ToTable("SalesPerson", "Sales");

            // keys
            builder.HasKey(t => t.SalesPersonID);

            // Properties
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .IsRequired();
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                ;
            builder.Property(t => t.SalesQuota)
                .HasColumnName("SalesQuota")
                .HasColumnType("decimal(19,4)");
            builder.Property(t => t.Bonus)
                .HasColumnName("Bonus")
                .HasColumnType("decimal(19,4)").IsRequired();
            builder.Property(t => t.CommissionPct)
                .HasColumnName("CommissionPct")
                .HasColumnType("decimal(19,4)").IsRequired();
            builder.Property(t => t.SalesYTD)
                .HasColumnName("SalesYTD")
                .HasColumnType("decimal(19,4)").IsRequired();
            builder.Property(t => t.SalesLastYear)
                .HasColumnName("SalesLastYear")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.SalesPeople)
                .HasForeignKey(d => d.SalesPersonID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesPeople)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
