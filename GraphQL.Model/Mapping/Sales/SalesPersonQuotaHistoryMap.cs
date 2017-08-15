using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesPersonQuotaHistoryMap : IEntityTypeConfiguration<SalesPersonQuotaHistory>
    {
        public void Map(EntityTypeBuilder<SalesPersonQuotaHistory> builder)
        {
            // table
            builder.ToTable("SalesPersonQuotaHistory", "Sales");

            // keys
            builder.HasKey(t => new { t.SalesPersonID, t.QuotaDate });

            // Properties
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .IsRequired();
            builder.Property(t => t.QuotaDate)
                .HasColumnName("QuotaDate")
                .IsRequired();
            builder.Property(t => t.SalesQuota)
                .HasColumnName("SalesQuota")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesPersonQuotaHistories)
                .HasForeignKey(d => d.SalesPersonID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
