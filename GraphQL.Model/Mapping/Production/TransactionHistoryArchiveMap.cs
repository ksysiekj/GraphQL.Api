using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class TransactionHistoryArchiveMap : IEntityTypeConfiguration<TransactionHistoryArchive>
    {
        public void Map(EntityTypeBuilder<TransactionHistoryArchive> builder)
        {
            // table
            builder.ToTable("TransactionHistoryArchive", "Production");

            // keys
            builder.HasKey(t => t.TransactionID);

            // Properties
            builder.Property(t => t.TransactionID)
                .HasColumnName("TransactionID")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.ReferenceOrderID)
                .HasColumnName("ReferenceOrderID")
                .IsRequired();
            builder.Property(t => t.ReferenceOrderLineID)
                .HasColumnName("ReferenceOrderLineID")
                .IsRequired();
            builder.Property(t => t.TransactionDate)
                .HasColumnName("TransactionDate")
                .IsRequired();
            builder.Property(t => t.TransactionType)
                .HasColumnName("TransactionType")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();
            builder.Property(t => t.ActualCost)
                .HasColumnName("ActualCost")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
