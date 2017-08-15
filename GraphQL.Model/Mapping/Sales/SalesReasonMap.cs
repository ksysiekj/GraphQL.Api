using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesReasonMap : IEntityTypeConfiguration<SalesReason>
    {
        public void Map(EntityTypeBuilder<SalesReason> builder)
        {
            // table
            builder.ToTable("SalesReason", "Sales");

            // keys
            builder.HasKey(t => t.SalesReasonID);

            // Properties
            builder.Property(t => t.SalesReasonID)
                .HasColumnName("SalesReasonID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ReasonType)
                .HasColumnName("ReasonType")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
