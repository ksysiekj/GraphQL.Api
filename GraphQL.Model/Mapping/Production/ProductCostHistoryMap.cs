using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductCostHistoryMap : IEntityTypeConfiguration<ProductCostHistory>
    {
        public void Map(EntityTypeBuilder<ProductCostHistory> builder)
        {
            // table
            builder.ToTable("ProductCostHistory", "Production");

            // keys
            builder.HasKey(t => new { t.ProductID, t.StartDate });

            // Properties
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                ;
            builder.Property(t => t.StandardCost)
            .HasColumnName("StandardCost")
            .HasColumnType("decimal(19,4)")
            .IsRequired();

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductCostHistories)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
